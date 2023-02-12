using Autofac;

namespace microserviceSeguros.Infrastruture.CrossCutting.IOC
{
    public class ModeuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}