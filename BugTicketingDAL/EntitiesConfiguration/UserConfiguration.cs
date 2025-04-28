using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTicketingDAL
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Ignore(u => u.PhoneNumber);
            builder.Ignore(u => u.PhoneNumberConfirmed);
            builder.HasData(Constant.SeedData.GetUsers());
        }
    }
}
