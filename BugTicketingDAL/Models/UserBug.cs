using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class UserBug
    {
        public string? UserId { get; set; }
        public Guid BugId { get; set; }
        public DateTime AssignedDate { get; set; }

        public User? User { get; set; }
        public Bug? Bug { get; set; }
    }
}
