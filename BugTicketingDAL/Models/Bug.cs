using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class Bug
    {
        public Guid id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public BugStatus Status { get; set; }
        public Guid ProjectId { get; set; }
        public Project? Project { get; set; }
        public List<UserBug>? UserBugs { get; set; }
        public List<Attachment>? Attachments { get; set; }
    }
}
