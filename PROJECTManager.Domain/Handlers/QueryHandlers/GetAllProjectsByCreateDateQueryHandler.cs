using AutoMapper;
using MediatR;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Domain.Models.RequestModels.QueryRequestModels;
using PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PROJECTManager.Domain.Handlers.QueryHandlers
{
    public class GetAllProjectsByCreateDateQueryHandler : IRequestHandler<GetAllProjectsByCreateDateRequestModel, IEnumerable<GetAllProjectsByCreateDateResponseModel>>
    {
        private readonly IProjectRepository projectRepository;
        private readonly IMapper mapper;

        public GetAllProjectsByCreateDateQueryHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            this.projectRepository = projectRepository;
            this.mapper = mapper;
        }

        private IEnumerable<GetAllProjectsByCreateDateResponseModel> responseModel;

        public async Task<IEnumerable<GetAllProjectsByCreateDateResponseModel>> Handle(GetAllProjectsByCreateDateRequestModel requestModel, CancellationToken cancellationToken)
        {
            var projectsModel = await projectRepository.GetAllByCreateDateAsync(requestModel.StartDate, requestModel.EndDate);

            responseModel = mapper.Map<IEnumerable<GetAllProjectsByCreateDateResponseModel>>(projectsModel);

            return responseModel;
        }
    }
}
