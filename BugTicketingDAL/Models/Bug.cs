using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class Bug
    {
        public Guid id {  get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public BugStatus Status { get; set; }
        public virtual List<UserBug>? UserBugs { get; set; }
    }
}
