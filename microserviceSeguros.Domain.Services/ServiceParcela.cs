using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Domain.Services
{
    public class ServiceParcela : ServiceBase<Parcela>, IServiceParcela
    {
        private readonly IRepositoryParcela repositoryParcelas;

        public ServiceParcela(IRepositoryParcela repositoryParcelas)
            : base(repositoryParcelas)
        {
            this.repositoryParcelas = repositoryParcelas;
        }
    }
}