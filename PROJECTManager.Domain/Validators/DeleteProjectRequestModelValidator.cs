using FluentValidation;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;

namespace PROJECTManager.Domain.Validators
{
    public class DeleteProjectRequestModelValidator : AbstractValidator<DeleteProjectRequestModel>
    {
        public DeleteProjectRequestModelValidator()
        {
            RuleFor(x => x.Id)
              .Length(10).WithMessage("The length of Id is 10 caracters");
        }
    }
}
