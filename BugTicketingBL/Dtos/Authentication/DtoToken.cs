using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingBL.Dtos.Authentication
{
    public class DtoToken
    {
        public string? Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
