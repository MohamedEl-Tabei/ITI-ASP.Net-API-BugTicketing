using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingBL.Dtos.Bug
{
    public class DtoReadBugWithProjectName
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
        public Guid ProjectId { get; set; }
        public string? ProjectName { get; set; }

    }

}
