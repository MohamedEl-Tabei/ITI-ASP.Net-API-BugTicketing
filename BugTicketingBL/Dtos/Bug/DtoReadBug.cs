using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL;

namespace BugTicketingBL.Dtos.Bug
{
    public class DtoReadBug
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
        public Guid ProjectId { get; set; }
    }
}
