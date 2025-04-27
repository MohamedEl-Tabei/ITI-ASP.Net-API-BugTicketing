
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BugTicketingDAL
{
    public class User : IdentityUser
    {
        public Project? ManagedProject { get; set; }
        public List<UserBug>? UserBugs { get; set; }
        public List<Attachment>? Attachments { get; set; }

    }
}
