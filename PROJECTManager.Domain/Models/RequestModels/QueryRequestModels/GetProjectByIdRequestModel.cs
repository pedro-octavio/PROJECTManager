using MediatR;
using PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels;

namespace PROJECTManager.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetProjectByIdRequestModel : IRequest<GetProjectByIdResponseModel>
    {
        public string Id { get; set; }
    }
}
