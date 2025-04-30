
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL;

namespace BugTicketingBL.Dtos
{
    public class DtoCreateBug
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public BugStatus Status { get; set; }
        public Guid ProjectId { get; set; }
    }
}
