using MediatR;
using PROJECTManager.Domain.Models.ResponseModels.CommandResponseModels;

namespace PROJECTManager.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateProjectRequestModel : IRequest<UpdateProjectResponseModel>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
