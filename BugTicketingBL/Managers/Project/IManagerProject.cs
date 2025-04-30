using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos.Project;

namespace BugTicketingBL.Managers
{
    public interface IManagerProject
    {
        public  Task<Guid> CreateProjectAsync(DtoCreateProject dtoCreateProject);
        public Task<List<DtoReadProject>> GetAllProjectsAsync();
        public Task<List<DtoProjectWithManagerAndBug>> GetProjectWithManagerAndBugsAsync(Guid id);
        public Task<Boolean> IsValidManager(DtoCreateProject dtoCreateProject);
    }

}
