using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class UserRole
    {
        public Guid UserId { get; set; }
        public Role Role { get; set; }
        public virtual User? User { get; set; }

    }
}
