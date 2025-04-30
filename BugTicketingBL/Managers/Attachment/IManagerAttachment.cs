using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos;

namespace BugTicketingBL.Managers
{
    public interface IManagerAttachment
    {
        public Task<Guid> CreateAsync(DtoCreateAttachment dtoCreateAttachment, string userId, Guid bugId);
        public void Delete(Guid attachmentID, Guid bugId);
        public Task<List<DtoReadAttachment>> GetAttachmentsForBug(Guid bugId);
    }
}
