using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL;

namespace BugTicketingBL.Dtos.Project
{
    public class DtoReadProject
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? ManagerId { get; set; }
    }
}
