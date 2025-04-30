using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos;
using BugTicketingBL.Dtos.Bug;
using BugTicketingBL.Dtos.Project;
using BugTicketingDAL;
using BugTicketingDAL.Repositories;

namespace BugTicketingBL.Managers
{
    public class ManagerBug : IManagerBug
    {
        private readonly IUnitOfWork _unitOfWork;
        public ManagerBug(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Guid> CreateBugAcync(DtoCreateBug dtoCreateBug)
        {
            var newBug = new Bug()
            {
                Description = dtoCreateBug.Description,
                Id = Guid.NewGuid(),
                ProjectId = dtoCreateBug.ProjectId,
                Status = dtoCreateBug.Status,
                Title = dtoCreateBug.Title,

            };

            await _unitOfWork._repoBug.CreateAsync(newBug);
            await _unitOfWork.SaveChangesAsync();
            return newBug.Id;
        }

        public async Task<List<DtoReadBug>> GetAllBugAcync()
        {
            var bugs = await _unitOfWork._repoBug.GetAllAsync();
            var result = bugs.Select(b => new DtoReadBug()
            {
                Id = b.Id,
                Description = b.Description,
                ProjectId = b.ProjectId,
                Status = b.Status == BugStatus.Solved ? "Solved" : "Not Solved",
                Title = b.Title,

            }).ToList();
            return result;
        }

        public async Task<DtoReadBugWithProjectName> GetBugsWithProjectNameByIdAsync(Guid id)
        {
            var bug = await _unitOfWork._repoBug.GetBugsWithProjectNameByIdAsync(id);
            return new DtoReadBugWithProjectName()
            {
                Id = id,
                Description = bug.Description,
                ProjectId = bug.ProjectId,
                ProjectName = bug.Project.Name,
                Status = bug.Status == BugStatus.Solved ? "Solved" : "Not Solved",
                Title = bug.Title,
            };
        }

        public async Task<bool> IsValidProjectAsync(DtoCreateBug dtoCreateBug)
        {
            var result = await _unitOfWork._repoProject.FindByIdAsync(dtoCreateBug.ProjectId);
            if (result is null) return false;
            return true;
        }
    }
}
