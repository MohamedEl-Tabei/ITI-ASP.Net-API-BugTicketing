using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public AttachmentType Type { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
