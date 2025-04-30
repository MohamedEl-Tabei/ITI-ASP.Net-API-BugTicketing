using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL.Repositories
{
    public class RepositoryBug : Repository<Bug>, IRepositoryBug
    {
        public RepositoryBug(BugTicketingContext context) : base(context)
        { }

        public async Task<Bug> GetBugsWithProjectNameByIdAsync(Guid id)
        {
            var result = await _context.Bugs.Include(b => b.Project).FirstOrDefaultAsync(b => b.Id == id);
            return result;
        }

        public async Task<List<Bug>> GetBugsWithProjectWithManagerByProjectIdAsync(Guid id)
        {
            var result = await _context.Bugs.Where(p => p.ProjectId == id).Include(p => p.Project).Include(p => p.Project.Manager).ToListAsync();
            return result;
        }
    }
}
