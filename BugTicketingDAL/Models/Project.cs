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
        public string? ManagerId { get; set; }
        public List<Bug>? Bugs { get; set; }
        public User? Manager { get; set; }
    }
}
