using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        public Task CreateAsync(T entity);
        public Task<T> FindByIdAsync(Guid Id);
        public Task<List<T>> GetAllAsync();
    }
}
