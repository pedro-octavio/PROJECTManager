using MediatR;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;
using PROJECTManager.Domain.Models.ResponseModels.CommandResponseModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PROJECTManager.Domain.Handlers.CommandHandlers
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectRequestModel, DeleteProjectResponseModel>
    {
        private readonly IProjectRepository projectRepository;

        public DeleteProjectCommandHandler(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        private DeleteProjectResponseModel responseModel;

        public async Task<DeleteProjectResponseModel> Handle(DeleteProjectRequestModel requestModel, CancellationToken cancellationToken)
        {
            var projectModel = await projectRepository.GetByIdAsync(requestModel.Id);

            if (projectModel != null)
            {
                await projectRepository.DeleteAsync(projectModel);

                return responseModel;
            }
            else
            {
                throw new Exception("The Id doens't exists");
            }
        }
    }
}
