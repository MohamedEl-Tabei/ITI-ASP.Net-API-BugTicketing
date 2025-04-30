using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL.Repositories
{
    public interface IRepositoryUserBug : IRepository<UserBug>
    {
        public void Delete(string userId, Guid bugId);
    }
}
