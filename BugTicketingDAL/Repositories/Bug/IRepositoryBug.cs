using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL.Repositories
{
    public interface IRepositoryBug : IRepository<Bug>
    {
        public Task<List<Bug>> GetBugsWithProjectWithManagerByProjectIdAsync(Guid id);
        public Task<Bug> GetBugsWithProjectNameByIdAsync(Guid id);

    }
}
