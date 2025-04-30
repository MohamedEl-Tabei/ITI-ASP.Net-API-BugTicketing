using BugTicketing.Validators;
using BugTicketingBL.Dtos.Project;
using BugTicketingBL.Managers;
using BugTicketingDAL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BugTicketing.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProjectController : ControllerBase
    {
        private readonly IManagerProject _managerProject;
        private readonly ValidatorCreateDtoProject _validatorCreateDtoProject;
        public ProjectController(IManagerProject managerProject, ValidatorCreateDtoProject validatorCreateDtoProject)
        {
            _managerProject = managerProject;
            _validatorCreateDtoProject = validatorCreateDtoProject;
        }
        [HttpPost]
        [Authorize(Policy = Constant.Policy.ManagerOnly)]
        public async Task<Results<Ok<string>, BadRequest<List<string>>>> CreateAsync(DtoCreateProject dtoCreateProject)
        {
            var validator = await _validatorCreateDtoProject.ValidateAsync(dtoCreateProject);
            if (!validator.IsValid)
            {
                return TypedResults.BadRequest(validator.Errors.Select(e => e.ErrorMessage).ToList());
            }
            var isValidManager = await _managerProject.IsValidManager(dtoCreateProject);
            if (!isValidManager) return TypedResults.BadRequest(new List<string>() { "Invalid Manager" });
            var id = await _managerProject.CreateProjectAsync(dtoCreateProject);

            return TypedResults.Ok(id.ToString());
        }
        [HttpGet]
        public async Task<Ok<List<DtoReadProject>>> GetAllAsync()
        {
            var result = await _managerProject.GetAllProjectsAsync();
            return TypedResults.Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<Ok<List<DtoProjectWithManagerAndBug>>> GetProjectDetailsAsync(Guid id)
        {
            var result = await _managerProject.GetProjectWithManagerAndBugsAsync(id);
            return TypedResults.Ok(result);
        }
    }
}
