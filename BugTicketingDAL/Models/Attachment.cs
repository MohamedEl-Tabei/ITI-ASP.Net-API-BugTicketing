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
        public Guid UserId { get; set; }
        public Guid BugId { get; set; }

        public virtual User? User { get; set; }
        public virtual Bug? Bug { get; set; }
    }
}
