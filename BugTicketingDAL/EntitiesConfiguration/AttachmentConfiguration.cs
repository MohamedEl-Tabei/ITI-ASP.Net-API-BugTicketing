using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTicketingDAL
{
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.Property(a => a.Title).HasMaxLength(100).IsRequired();
            builder.HasOne(a=>a.User).WithMany(u=>u.Attachments).HasForeignKey(a=>a.UserId);
            builder.HasOne(a=>a.Bug).WithMany(b=>b.Attachments).HasForeignKey(a=>a.BugId);
        }
    }
}
