using AutoMapper;
using MediatR;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Data.Models;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;
using PROJECTManager.Domain.Models.ResponseModels.CommandResponseModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PROJECTManager.Domain.Handlers.CommandHandlers
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectRequestModel, UpdateProjectResponseModel>
    {
        private readonly IProjectRepository projectRepository;
        private readonly IMapper mapper;

        public UpdateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            this.projectRepository = projectRepository;
            this.mapper = mapper;
        }

        private UpdateProjectResponseModel responseModel;

        public async Task<UpdateProjectResponseModel> Handle(UpdateProjectRequestModel requestModel, CancellationToken cancellationToken)
        {
            var projectModel = await projectRepository.GetByIdAsync(requestModel.Id);

            if (projectModel != null)
            {
                var projectModelCreateDate = projectModel.CreateDate;

                projectModel = mapper.Map<ProjectModel>(requestModel);

                projectModel.CreateDate = projectModelCreateDate;

                await projectRepository.UpdateAsync(projectModel);

                return responseModel;
            }
            else
            {
                throw new Exception("Id doens't exists");
            }
        }
    }
}
