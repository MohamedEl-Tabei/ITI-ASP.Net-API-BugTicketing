using BugTicketingBL.Dtos.Project;
using BugTicketingDAL;
using FluentValidation;

namespace BugTicketing.Validators
{
    public class ValidatorCreateDtoProject : AbstractValidator<DtoCreateProject>
    {
        public ValidatorCreateDtoProject(IConfiguration configuration, IUnitOfWork unitOfWork)
        {

            RuleFor(p => p.Name).NotEmpty().WithMessage("Name is Required");
            RuleFor(p => p.EndDate).NotEmpty().WithMessage("EndDate is Required");
            RuleFor(p => p.Status).NotEmpty().WithMessage("Status is Required").IsInEnum().WithMessage("Invalid Status (1,Finised) (-1,NotFinished) ");
            RuleFor(p => p.StartDate).NotEmpty().WithMessage("StartDate is Required");
            RuleFor(p => p.ManagerId).NotEmpty().WithMessage("ManagerId is Required").Must(m => Guid.TryParse(m, out _)).WithMessage("Invalid ManagerId");
        }
    }
}
