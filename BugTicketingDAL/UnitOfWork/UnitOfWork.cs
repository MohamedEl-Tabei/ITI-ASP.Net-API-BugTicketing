using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL.Repositories;

namespace BugTicketingDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BugTicketingContext _context;
        public IRepositoryProject _repoProject { get; }
        public IRepositoryAttachment _repoAttachment { get; }
        public IRepositoryUserBug _repoUserBug { get; }
        public IRepositoryBug _repoBug { get; }
        public UnitOfWork(BugTicketingContext context, IRepositoryProject repositoryProject, IRepositoryBug repositoryBug, IRepositoryUserBug repoUserBug)
        {
            _context = context;
            _repoProject = repositoryProject;
            _repoBug = repositoryBug;
            _repoUserBug = repoUserBug;
        }

        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

    }
}
