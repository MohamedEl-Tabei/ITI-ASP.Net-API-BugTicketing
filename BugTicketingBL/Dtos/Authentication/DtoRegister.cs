using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL;

namespace BugTicketingBL.Dtos.Authentication
{
    public class DtoRegister
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
