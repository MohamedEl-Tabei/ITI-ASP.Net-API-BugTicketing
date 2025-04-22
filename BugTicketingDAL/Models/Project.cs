using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class Project
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid ManagerId { get; set; }
        public virtual List<Bug>? Bugs {  get; set; } 
        public virtual User? Manager { get; set; }
    }
}
