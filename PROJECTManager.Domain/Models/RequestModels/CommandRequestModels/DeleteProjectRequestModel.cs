using MediatR;
using PROJECTManager.Domain.Models.ResponseModels.CommandResponseModels;

namespace PROJECTManager.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteProjectRequestModel : IRequest<DeleteProjectResponseModel>
    {
        public string Id { get; set; }
    }
}
