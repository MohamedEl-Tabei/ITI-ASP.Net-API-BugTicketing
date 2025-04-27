using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTicketingDAL.EntitiesConfiguration
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var Roles = new List<IdentityRole>()
            {

                new IdentityRole(){Name="Manager",NormalizedName="MANAGER",Id="0b172061-cc4b-416d-8559-4dcb240cd012"},
                new IdentityRole(){Name="Developer",NormalizedName="DEVELOPER",Id="4179d4b9-6aa8-4e27-8293-9fd69b331e8a"},
                new IdentityRole(){Name="Tester",NormalizedName="TESTER",Id="bcd832ec-cae3-4b7b-baa6-f9f02b9858c0"},
            };
            builder.HasData(Roles);
        }
    }
}
