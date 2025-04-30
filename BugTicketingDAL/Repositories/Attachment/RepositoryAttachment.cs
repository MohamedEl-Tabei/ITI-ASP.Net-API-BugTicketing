using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugTicketingDAL.Repositories
{
    public class RepositoryAttachment : Repository<Attachment>, IRepositoryAttachment
    {
        public RepositoryAttachment(BugTicketingContext context) : base(context)
        {
        }
        public void Delete(Guid attachmentId, Guid bugId)
        {
            var attachment = _context.Attachments.FirstOrDefault(ub => ub.Id == attachmentId && ub.BugId == bugId);
            _context.Remove(attachment);
        }
        public async Task<List<Attachment>> GetAttachmentsByBugIdAsync(Guid bugId)
        {
            var result = await _context.Attachments.Where(a => a.BugId == bugId).ToListAsync();
            return result;
        }
    }
}
