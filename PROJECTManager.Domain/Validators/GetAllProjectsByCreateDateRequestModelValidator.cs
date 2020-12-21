using FluentValidation;
using PROJECTManager.Domain.Models.RequestModels.QueryRequestModels;

namespace PROJECTManager.Domain.Validators
{
    public class GetAllProjectsByCreateDateRequestModelValidator : AbstractValidator<GetAllProjectsByCreateDateRequestModel>
    {
        public GetAllProjectsByCreateDateRequestModelValidator()
        {

        }
    }
}
