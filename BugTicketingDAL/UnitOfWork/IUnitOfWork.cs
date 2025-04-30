using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL.Repositories;

namespace BugTicketingDAL
{
    public interface IUnitOfWork
    {
        public IRepositoryProject _repoProject { get; }
        public IRepositoryBug _repoBug { get; }
        public IRepositoryUserBug _repoUserBug { get; }
        public IRepositoryAttachment _repoAttachment { get; }

        public Task<int> SaveChangesAsync();
    }
}
