using AutoMapper;
using MediatR;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Data.Models;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;
using PROJECTManager.Domain.Models.ResponseModels.CommandResponseModels;
using System.Threading;
using System.Threading.Tasks;

namespace PROJECTManager.Domain.Handlers.CommandHandlers
{
    public class AddProjectCommandHandler : IRequestHandler<AddProjectRequestModel, AddProjectResponseModel>
    {
        private readonly IProjectRepository projectRepository;
        private readonly IMapper mapper;

        public AddProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            this.projectRepository = projectRepository;
            this.mapper = mapper;
        }

        private AddProjectResponseModel responseModel;

        public async Task<AddProjectResponseModel> Handle(AddProjectRequestModel requestModel, CancellationToken cancellationToken)
        {
            var projectModel = mapper.Map<ProjectModel>(requestModel);

            await projectRepository.AddAsync(projectModel);

            responseModel = new AddProjectResponseModel
            {
                Id = projectModel.Id
            };

            return responseModel;
        }
    }
}
