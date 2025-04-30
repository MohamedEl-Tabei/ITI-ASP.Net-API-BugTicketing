using BugTicketing.Validators;
using BugTicketingBL.Dtos;
using BugTicketingBL.Dtos.Bug;
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
    public class BugController : ControllerBase
    {
        private readonly ValidatorCreateDtoBug _validatorCreateDtoBug;
        private readonly IManagerBug _managerBug;

        public BugController(IManagerBug managerBug, ValidatorCreateDtoBug validatorCreateDtoBug)
        {
            _validatorCreateDtoBug = validatorCreateDtoBug;
            _managerBug = managerBug;
        }
        [HttpPost]
        [Authorize(Policy = Constant.Policy.TesterOnly)]
        public async Task<Results<Ok<Guid>, BadRequest<List<string>>>> CreateAsync(DtoCreateBug dtoCreateBug)
        {
            var validator = await _validatorCreateDtoBug.ValidateAsync(dtoCreateBug);
            if (!validator.IsValid) return TypedResults.BadRequest(validator.Errors.Select(e => e.ErrorMessage).ToList());
            var validProject = await _managerBug.IsValidProjectAsync(dtoCreateBug);
            if (!validProject) return TypedResults.BadRequest(new List<string> { "Invalid ProjectID" });
            var bugId = await _managerBug.CreateBugAcync(dtoCreateBug);
            return TypedResults.Ok(bugId);
        }
        [HttpGet]
        public async Task<Ok<List<DtoReadBug>>> GetAllAsync()
        {
            var result = await _managerBug.GetAllBugAcync();
            return TypedResults.Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<Ok<DtoReadBugWithProjectName>> GetBugDetails(Guid id)
        {
            var result = await _managerBug.GetBugsWithProjectNameByIdAsync(id);
            return TypedResults.Ok(result);
        }
    }
}
