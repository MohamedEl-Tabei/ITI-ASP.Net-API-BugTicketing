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
            builder.Property(u=>u.Email).IsRequired();
            builder.Property(u=>u.FName).IsRequired();
            builder.Property(u=>u.LName).IsRequired();
            builder.Property(u=>u.Password).IsRequired();
        }
    }
}
