
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FName {  get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public virtual string? Name { get; set; }
        public virtual Project? ManagedProject { get; set; }
        public virtual List<UserBug>? UserBugs { get; set; }
        public virtual List<UserRole>? UserRoles { get; set; }
        public virtual List<Attachment>? Attachments { get; set; }

    }
}
