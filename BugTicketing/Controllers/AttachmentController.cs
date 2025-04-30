using System.Security.Claims;
using BugTicketingBL.Dtos;
using BugTicketingBL.Managers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BugTicketing.Controllers
{
    [Route("api/bugs")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AttachmentController : ControllerBase
    {
        private readonly IManagerAttachment _managerAttachment;

        public AttachmentController(IManagerAttachment managerAttachment)
        {
            _managerAttachment = managerAttachment;
        }
        [HttpPost("{bugId}/attachments")]
        public async Task<Created> UploadAttachment(Guid bugId, [FromForm] DtoCreateAttachment dtoCreateAttachment)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            await _managerAttachment.CreateAsync(dtoCreateAttachment, userId, bugId);

            return TypedResults.Created();
        }

        [HttpGet("{id}/attachments")]

        public async Task<Ok<List<DtoReadAttachment>>> GetAttachmentsForBug(Guid id)
        {
            var result = await _managerAttachment.GetAttachmentsForBug(id);
            return TypedResults.Ok(result);
        }
        [HttpDelete("{bugId}/attachments/{attachmetnId}")]
        public Ok<string> RemoveUserfromBug(Guid attachmetnId, Guid bugId)
        {
            _managerAttachment.Delete(attachmetnId, bugId);
            return TypedResults.Ok("deleted");
        }
    }
}
