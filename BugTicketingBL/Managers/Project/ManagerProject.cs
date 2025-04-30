using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos.Project;
using BugTicketingDAL;
using Microsoft.AspNetCore.Identity;

namespace BugTicketingBL.Managers
{
    internal class ManagerProject : IManagerProject
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public ManagerProject(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;

        }
        public async Task<Guid> CreateProjectAsync(DtoCreateProject dtoCreateProject)
        {
            var newProject = new Project()
            {
                Name = dtoCreateProject.Name,
                Id = Guid.NewGuid(),
                ManagerId = dtoCreateProject.ManagerId,
                EndDate = dtoCreateProject.EndDate,
                StartDate = dtoCreateProject.StartDate,
                Status = dtoCreateProject.Status,
            };
            await _unitOfWork._repoProject.CreateAsync(newProject);
            await _unitOfWork.SaveChangesAsync();
            return newProject.Id;
        }
        public async Task<List<DtoProjectWithManagerAndBug>> GetProjectWithManagerAndBugsAsync(Guid id)
        {
            var projectBugs = await _unitOfWork._repoBug.GetBugsWithProjectWithManagerByProjectIdAsync(id);
            var result = projectBugs.Select(pb => new DtoProjectWithManagerAndBug()
            {
                Id = pb.Project.Id,
                ManagerId = pb.Project.ManagerId,
                BugId = pb.Id,
                BugName = pb.Title,
                BugStatus = pb.Status == BugStatus.Solved ? "Solved" : "Not Solved",
                EndDate = pb.Project.EndDate,
                ManagerName = pb.Project.Manager.UserName,
                Name = pb.Project.Name,
                ProjecStatus = pb.Project.Status == ProjectStatus.Finished ? "Finished" : "Not Finished",
                StartDate = pb.Project.StartDate

            }).ToList();
            return result;
        }
        public async Task<List<DtoReadProject>> GetAllProjectsAsync()
        {
            var projects = await _unitOfWork._repoProject.GetAllAsync();
            var result = projects.Select(p => new DtoReadProject()
            {
                Name = p.Name,
                Id = p.Id,
                ManagerId = p.ManagerId,
                EndDate = p.EndDate,
                StartDate = p.StartDate,
                Status = p.Status == ProjectStatus.Finished ? "Finshed" : "Not Finished",

            }).ToList();
            return result;
        }

        public async Task<bool> IsValidManager(DtoCreateProject dtoCreateProject)
        {
            var id = dtoCreateProject.ManagerId;
            var user = await _userManager.FindByIdAsync(id);
            if (user is null) return false;
            var res = await _userManager.IsInRoleAsync(user, Constant.Role.Manager);
            return res;
        }
    }
}
