using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BugTicketingDAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace BugTicketingDAL
{
    public static class DALExtensions
    {
        public static void AddDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region Depandancy Injection for Repositories & UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepositoryProject, RepositoryProject>();
            services.AddScoped<IRepositoryBug, RepositoryBug>();
            services.AddScoped<IRepositoryUserBug, RepositoryUserBug>();
            services.AddScoped<IRepositoryAttachment, RepositoryAttachment>();
            #endregion
            #region Identity
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<BugTicketingContext>();
            #endregion
            #region Authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                var secretKey = configuration.GetValue<string>("JWT:SecretKey");
                var secretKeyInBytes = Encoding.UTF8.GetBytes(secretKey);
                var key = new SymmetricSecurityKey(secretKeyInBytes);
                options.TokenValidationParameters = new()
                {
                    IssuerSigningKey = key,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                };
            });

            #endregion
            #region Authorization
            services.AddAuthorization(opions =>
            {
                opions.AddPolicy(Constant.Policy.ManagerOnly, builder => builder.RequireClaim(ClaimTypes.Role, Constant.Role.Manager).RequireClaim(ClaimTypes.NameIdentifier));
                opions.AddPolicy(Constant.Policy.TesterOnly, builder => builder.RequireClaim(ClaimTypes.Role, Constant.Role.Tester).RequireClaim(ClaimTypes.NameIdentifier));
                opions.AddPolicy(Constant.Policy.DevelopreOnly, builder => builder.RequireClaim(ClaimTypes.Role, Constant.Role.Developer).RequireClaim(ClaimTypes.NameIdentifier));
            });
            #endregion
            #region DbContext
            services.AddDbContext<BugTicketingContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            #endregion

        }
    }
}

