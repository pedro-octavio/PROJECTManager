using FluentValidation;
using PROJECTManager.Domain.Models.RequestModels.QueryRequestModels;

namespace PROJECTManager.Domain.Validators
{
    public class GetProjectByIdRequestModelValidator : AbstractValidator<GetProjectByIdRequestModel>
    {
        public GetProjectByIdRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .Length(10).WithMessage("The length of Id is 10 caracters");
        }
    }
}
