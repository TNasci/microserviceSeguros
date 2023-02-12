using Autofac;
using microserviceSeguros.Application;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Application.Mappers;
using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Services;
using microserviceSeguros.Infrastruture.Data.Repositorys;

namespace microserviceSeguros.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceApolice>().As<IApplicationServiceApolice>();
            builder.RegisterType<ApplicationServiceParcelas>().As<IApplicationServiceParcela>();
            builder.RegisterType<ApplicationServicePagamento>().As<IApplicationServicePagamento>();
            builder.RegisterType<ServiceApolice>().As<IServiceApolice>();
            builder.RegisterType<ServiceParcela>().As<IServiceParcela>();
            builder.RegisterType<ServicePagamento>().As<IServicePagamento>();
            builder.RegisterType<RepositoryApolice>().As<IRepositoryApolice>();
            builder.RegisterType<RepositoryParcela>().As<IRepositoryParcela>();
            builder.RegisterType<MapperApolice>().As<IMapperApolice>();
            builder.RegisterType<MapperParcela>().As<IMapperParcela>();
            builder.RegisterType<MapperPagamento>().As<IMapperPagamento>();

            #endregion IOC
        }
    }
}