using BugTicketingBL.Dtos;
using FluentValidation;

namespace BugTicketing.Validators
{
    public class ValidatorCreateDtoBug : AbstractValidator<DtoCreateBug>
    {
        public ValidatorCreateDtoBug()
        {
            RuleFor(b => b.Description).NotEmpty().WithMessage("Description is Required");
            RuleFor(b => b.Status).NotEmpty().WithMessage("Status is Required").IsInEnum().WithMessage("Invalid status (1,solved) (-1,notSolved)");
            RuleFor(b => b.Title).NotEmpty().WithMessage("Title is Required");
            RuleFor(b => b.ProjectId).NotEmpty().WithMessage("ProjectId is Required").Must(v => Guid.TryParse(v.ToString(), out _)).WithMessage("Invalid ProjectId");


        }
    }
}
