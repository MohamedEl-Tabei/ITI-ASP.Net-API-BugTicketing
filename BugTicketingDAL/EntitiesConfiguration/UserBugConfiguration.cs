using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTicketingDAL
{
    public class UserBugConfiguration : IEntityTypeConfiguration<UserBug>
    {
        public void Configure(EntityTypeBuilder<UserBug> builder)
        {
            builder.HasKey(ub => new { ub.BugId, ub.UserId });
            builder.HasOne(ub=>ub.User).WithMany(u=>u.UserBugs).HasForeignKey(u=>u.UserId);
            builder.HasOne(ub=>ub.Bug).WithMany(b=>b.UserBugs).HasForeignKey(b=>b.BugId);
        }
    }
}
