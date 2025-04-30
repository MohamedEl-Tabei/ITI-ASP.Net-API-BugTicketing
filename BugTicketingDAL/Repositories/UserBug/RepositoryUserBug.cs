using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL.Repositories
{
    public class RepositoryUserBug : Repository<UserBug>, IRepositoryUserBug
    {
        public RepositoryUserBug(BugTicketingContext context) : base(context)
        {

        }
        public void Delete(string userId, Guid bugId)
        {
            var userBug = _context.UserBugs.FirstOrDefault(ub => ub.UserId == userId && ub.BugId == bugId);
            _context.Remove(userBug);
        }
    }
}
