using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos;
using BugTicketingDAL;

namespace BugTicketingBL.Managers
{
    public class ManagerAttachment : IManagerAttachment
    {
        private readonly UnitOfWork _unitOfWork;

        public ManagerAttachment(UnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }
        public async Task<Guid> CreateAsync(DtoCreateAttachment dtoCreateAttachment)
        {
            var stream = new MemoryStream();
            await dtoCreateAttachment.file.CopyToAsync(stream);
            var newAttachment = new Attachment()
            {
                BugId = dtoCreateAttachment.BugId,
                UserId = dtoCreateAttachment.UserId,
                Title = dtoCreateAttachment.Title,
                Id = Guid.NewGuid(),
                file = stream.ToArray(),
            };
            await _unitOfWork.SaveChangesAsync();
            return newAttachment.Id;
        }
    }
}
