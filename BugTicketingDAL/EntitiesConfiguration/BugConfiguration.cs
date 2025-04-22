using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTicketingDAL
{
    public class BugConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.Description).IsRequired();
            builder.Property(b => b.Status).IsRequired();
            builder.HasOne(b => b.Project).WithMany(p => p.Bugs).HasForeignKey(b => b.ProjectId);
        }
    }
}
