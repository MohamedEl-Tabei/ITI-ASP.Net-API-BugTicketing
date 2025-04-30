using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected BugTicketingContext _context;
        public Repository(BugTicketingContext context) => _context = context;
        public async Task CreateAsync(T entity) => await _context.Set<T>().AddAsync(entity);

        public async Task<T> FindByIdAsync(Guid Id) => await _context.Set<T>().FindAsync(Id);

        public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

    }
}
