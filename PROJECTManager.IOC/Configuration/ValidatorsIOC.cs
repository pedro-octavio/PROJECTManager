using Autofac;
using FluentValidation;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;
using PROJECTManager.Domain.Models.RequestModels.QueryRequestModels;
using PROJECTManager.Domain.Validators;

namespace PROJECTManager.IOC.Configuration
{
    public class ValidatorsIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<GetAllProjectsByCreateDateRequestModelValidator>().As<IValidator<GetAllProjectsByCreateDateRequestModel>>();
            containerBuilder.RegisterType<GetProjectByIdRequestModelValidator>().As<IValidator<GetProjectByIdRequestModel>>();
            containerBuilder.RegisterType<AddProjectRequestModelValidator>().As<IValidator<AddProjectRequestModel>>();
            containerBuilder.RegisterType<UpdateProjectRequestModelValidator>().As<IValidator<UpdateProjectRequestModel>>();
            containerBuilder.RegisterType<DeleteProjectRequestModelValidator>().As<IValidator<DeleteProjectRequestModel>>();
        }
    }
}
