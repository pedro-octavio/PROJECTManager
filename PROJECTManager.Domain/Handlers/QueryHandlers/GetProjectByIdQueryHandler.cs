using AutoMapper;
using MediatR;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Domain.Models.RequestModels.QueryRequestModels;
using PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PROJECTManager.Domain.Handlers.QueryHandlers
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdRequestModel, GetProjectByIdResponseModel>
    {
        private readonly IProjectRepository projectRepository;
        private readonly IMapper mapper;

        public GetProjectByIdQueryHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            this.projectRepository = projectRepository;
            this.mapper = mapper;
        }

        private GetProjectByIdResponseModel responseModel;

        public async Task<GetProjectByIdResponseModel> Handle(GetProjectByIdRequestModel requestModel, CancellationToken cancellationToken)
        {
            var projectModel = await projectRepository.GetByIdAsync(requestModel.Id);

            if (projectModel == null)
            {
                throw new Exception("Project doesn't exists");
            }

            responseModel = mapper.Map<GetProjectByIdResponseModel>(projectModel);

            return responseModel;
        }
    }
}
