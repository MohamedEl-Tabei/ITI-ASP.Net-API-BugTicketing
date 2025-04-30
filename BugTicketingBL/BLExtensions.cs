using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Managers;
using BugTicketingBL.Managers.Attachment;
using Microsoft.Extensions.DependencyInjection;

namespace BugTicketingBL
{
    public static class BLExtensions
    {
        public static void AddBLExtensions(this IServiceCollection services)
        {
            services.AddScoped<IManagerProject, ManagerProject>();
            services.AddScoped<IManagerBug, ManagerBug>();
            services.AddScoped<IManagerUserBug, ManagerUserBug>();
            services.AddScoped<IManagerAttachment, ManagerAttachment>();
        }
    }
}
