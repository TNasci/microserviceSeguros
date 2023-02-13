using Autofac;
using AutoMapper;
using microserviceSeguros.Application;
using microserviceSeguros.Application.Interfaces;
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
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DTOToModelMappingApolice());
                cfg.AddProfile(new ModelToDTOMappingApolice());
                cfg.AddProfile(new DTOToModelMappingParcela());
                cfg.AddProfile(new ModelToDTOMappingParcela());
                cfg.AddProfile(new DTOToModelMappingPagamento());
                cfg.AddProfile(new ModelToDTOMappingPagamento());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>()
                .InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}