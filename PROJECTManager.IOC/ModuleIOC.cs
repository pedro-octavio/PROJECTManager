using Autofac;

namespace PROJECTManager.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            ConfigurationIOC.Load(containerBuilder);
        }
    }
}
