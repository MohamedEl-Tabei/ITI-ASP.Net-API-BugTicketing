using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL.Repositories
{
    public class RepositoryUserBug : Repository<UserBug>, IRepositoryUserBug
    {
        public RepositoryUserBug(BugTicketingContext context) : base(context)
        {
        }
    }
}
