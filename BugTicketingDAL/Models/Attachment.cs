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
        public DateTime UploadedAt { get; set; }
        public string? UserId { get; set; }
        public Guid BugId { get; set; }
        public string? filePath { get; set; }

        public User? User { get; set; }
        public Bug? Bug { get; set; }
        public Attachment()
        {
            UploadedAt = DateTime.Now;
        }
    }
}
