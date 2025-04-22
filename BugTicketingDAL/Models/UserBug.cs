using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class UserBug
    {
        public Guid UserId { get; set; }
        public Guid BugId { get; set; }
        public DateTime AssignedDate { get; set; }

        public virtual User? User { get; set; }
        public virtual Bug? Bug { get; set; }
    }
}
