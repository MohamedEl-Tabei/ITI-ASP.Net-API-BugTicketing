using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos;
using BugTicketingBL.Dtos.Bug;
using BugTicketingBL.Dtos.Project;

namespace BugTicketingBL.Managers
{
    public interface IManagerBug
    {
        public Task<Guid> CreateBugAcync(DtoCreateBug dtoCreateBug);
        public Task<List<DtoReadBug>> GetAllBugAcync();
        public Task<DtoReadBugWithProjectName> GetBugsWithProjectNameByIdAsync(Guid id);
        public Task<bool> IsValidProjectAsync(DtoCreateBug dtoCreateBug);
    }
}
