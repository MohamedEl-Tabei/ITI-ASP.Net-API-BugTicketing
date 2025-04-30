using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTicketingBL.Dtos;
using BugTicketingDAL;
using Microsoft.AspNetCore.Http;

namespace BugTicketingBL.Managers
{
    public class ManagerAttachment : IManagerAttachment
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManagerAttachment(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }
        public void Delete(Guid attachmentID, Guid bugId)
        {
            _unitOfWork._repoAttachment.Delete(attachmentID, bugId);
            _unitOfWork.SaveChanges();
        }

        public async Task<Guid> CreateAsync(DtoCreateAttachment dtoCreateAttachment, string userId, Guid bugId)
        {
            var file = dtoCreateAttachment.file;
            var exteenstion = Path.GetExtension(file.FileName).ToLowerInvariant();
            var filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Images",
                $"{Guid.NewGuid()}{exteenstion}");

            using var stream = new FileStream(filePath, FileMode.Create);


            await dtoCreateAttachment.file.CopyToAsync(stream);
            var newAttachment = new Attachment()
            {
                BugId = bugId,
                UserId = userId,
                Title = dtoCreateAttachment.Title,
                Id = Guid.NewGuid(),
                filePath = $"/api/static-files/{Path.GetFileName(filePath)}",
            };
            await _unitOfWork._repoAttachment.CreateAsync(newAttachment);
            await _unitOfWork.SaveChangesAsync();
            return newAttachment.Id;
        }

        public async Task<List<DtoReadAttachment>> GetAttachmentsForBug(Guid bugId)
        {
            var attachments = await _unitOfWork._repoAttachment.GetAttachmentsByBugIdAsync(bugId);
            if (attachments is null) return null;
            var result = attachments.Select(a => new DtoReadAttachment()
            {
                BugId = a.BugId,
                UserId = a.UserId,
                Title = a.Title,
                file = a.filePath,
                Id = a.Id,
                UploadedAt = a.UploadedAt,
            }).ToList();
            return result;
        }

    }
}
