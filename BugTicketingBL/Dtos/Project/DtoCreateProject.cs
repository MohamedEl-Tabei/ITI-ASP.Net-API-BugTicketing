using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL;

namespace BugTicketingBL.Dtos.Project
{
    public class DtoCreateProject
    {
        public string? Name { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? ManagerId { get; set; }
    }
}
