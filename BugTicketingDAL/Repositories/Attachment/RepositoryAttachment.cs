using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL.Repositories
{
    public class RepositoryAttachment : Repository<Attachment>, IRepositoryAttachment
    {
        public RepositoryAttachment(BugTicketingContext context) : base(context)
        {
        }
    }
}
