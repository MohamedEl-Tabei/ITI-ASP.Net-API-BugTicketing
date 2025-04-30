using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTicketingDAL.Repositories
{
    public interface IRepositoryAttachment : IRepository<Attachment>
    {
        public void Delete(Guid attachmentId, Guid bugId);
        public Task<List<Attachment>> GetAttachmentsByBugIdAsync(Guid bugId);
    }
}
