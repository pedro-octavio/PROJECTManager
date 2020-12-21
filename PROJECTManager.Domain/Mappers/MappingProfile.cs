using AutoMapper;
using PROJECTManager.Data.Models;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;
using PROJECTManager.Domain.Models.ResponseModels.QueryResponseModels;

namespace PROJECTManager.Domain.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddProjectRequestModel, ProjectModel>();
            CreateMap<UpdateProjectRequestModel, ProjectModel>();

            CreateMap<ProjectModel, GetAllProjectsByCreateDateResponseModel>();
            CreateMap<ProjectModel, GetProjectByIdResponseModel>();
        }
    }
}
