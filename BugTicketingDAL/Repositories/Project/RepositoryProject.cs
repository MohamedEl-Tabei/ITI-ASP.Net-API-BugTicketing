using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL.Repositories
{
    public class RepositoryProject:Repository<Project>, IRepositoryProject
    {
       public RepositoryProject(BugTicketingContext context):base(context) { }

        
    }
}
