using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL
{
    public class BugTicketingContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public BugTicketingContext(DbContextOptions<BugTicketingContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BugTicketingContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
