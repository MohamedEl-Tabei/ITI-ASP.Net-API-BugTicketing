using BugTicketingBL.Managers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BugTicketing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AttachmentController : ControllerBase
    {
        private readonly IManagerAttachment _managerAttachment;

        public AttachmentController(IManagerAttachment managerAttachment)
        {
            _managerAttachment = managerAttachment;
        }
    }
}
