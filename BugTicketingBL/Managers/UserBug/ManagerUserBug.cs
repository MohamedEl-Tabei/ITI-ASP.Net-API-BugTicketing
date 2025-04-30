using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL;
using Microsoft.AspNetCore.Identity;

namespace BugTicketingBL.Managers
{
    public class ManagerUserBug : IManagerUserBug
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public ManagerUserBug(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task CreateAsync(Guid bugId, string userId)
        {
            var userBug = new UserBug()
            {
                BugId = bugId,
                UserId = userId,
            };
            await _unitOfWork._repoUserBug.CreateAsync(userBug);
            await _unitOfWork.SaveChangesAsync();
        }

        public void Delete(string userId, Guid bugId)
        {
            _unitOfWork._repoUserBug.Delete(userId, bugId);
            _unitOfWork.SaveChanges();
        }

        public async Task<bool> IsDeveloperAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            var isDeveloper = await _userManager.IsInRoleAsync(user, Constant.Role.Developer);
            return isDeveloper;
        }

        public async Task<bool> IsValidBugAsync(Guid bugId)
        {
            var bug = await _unitOfWork._repoBug.FindByIdAsync(bugId);
            if (bug is null) return false;
            return true;
        }

    }
}
