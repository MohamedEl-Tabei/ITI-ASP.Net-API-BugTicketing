using BugTicketingBL.Dtos.UserBug;
using BugTicketingBL.Managers;
using BugTicketingDAL;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BugTicketing.Controllers
{
    [Route("api/bugs")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = Constant.Policy.ManagerOnly)]

    public class UserBugController : ControllerBase
    {
        private readonly IManagerUserBug _managerUserBug;

        public UserBugController(IManagerUserBug managerUserBug)
        {
            _managerUserBug = managerUserBug;
        }
        [HttpPost("{bugId}/assignees")]
        public async Task<Results<Created, BadRequest<string>>> AssignUserToBug(Guid bugId, [FromBody] DtoUserId userId)
        {
            var isValidBug = await _managerUserBug.IsValidBugAsync(bugId);
            if (!isValidBug) return TypedResults.BadRequest("Invalid Bug");
            var isDeveloper = await _managerUserBug.IsDeveloperAsync(userId.Id);
            if (!isDeveloper) return TypedResults.BadRequest("User is not Developer");
            await _managerUserBug.CreateAsync(bugId, userId.Id);

            return TypedResults.Created();
        }
    }
}
