using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingBL.Dtos
{
    public class DtoReadAttachment
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime UploadedAt { get; set; }
        public string? UserId { get; set; }

        public Guid BugId { get; set; }
        public string file { get; set; }
    }
}
