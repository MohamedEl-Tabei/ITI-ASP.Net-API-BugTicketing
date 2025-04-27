using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL
{
    public class BugTicketingContext : IdentityDbContext<User>
    {
        public DbSet<UserBug> UserBugs { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Project> Projects { get; set; }

        public BugTicketingContext(DbContextOptions<BugTicketingContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BugTicketingContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
