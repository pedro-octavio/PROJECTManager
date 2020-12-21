using FluentValidation;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;

namespace PROJECTManager.Domain.Validators
{
    public class AddProjectRequestModelValidator : AbstractValidator<AddProjectRequestModel>
    {
        public AddProjectRequestModelValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("The Name cannot be null")
                .NotEmpty().WithMessage("The Name cannot be empty")
                .MaximumLength(50).WithMessage("The maximum length of Name is 50 caracters");

            RuleFor(x => x.Description)
                .MaximumLength(4200).WithMessage("The maximum length of Description is 4200 caracters");
        }
    }
}
