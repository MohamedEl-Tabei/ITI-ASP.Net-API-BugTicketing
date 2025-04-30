using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingBL.Managers
{
    public interface IManagerUserBug
    {
        public Task CreateAsync(Guid bugId, string userId);
        public Task<bool> IsValidBugAsync(Guid bugId);
        public Task<Boolean> IsDeveloperAsync(string userId);
        public void Delete(string userId, Guid bugId);

    }
}
