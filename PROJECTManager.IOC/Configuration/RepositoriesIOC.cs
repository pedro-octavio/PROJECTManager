using Autofac;
using PROJECTManager.Data.Interfaces;
using PROJECTManager.Data.Repositories;

namespace PROJECTManager.IOC.Configuration
{
    public class RepositoriesIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ProjectRepository>().As<IProjectRepository>();
        }
    }
}
