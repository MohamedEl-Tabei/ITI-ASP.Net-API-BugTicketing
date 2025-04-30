using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BugTicketingBL.Dtos
{
    public class DtoCreateAttachment
    {
        public string? Title { get; set; }
        public string? UserId { get; set; }
        public Guid BugId { get; set; }
        public IFormFile? file { get; set; }

    }
}
