using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Domain.Services
{
    public class ServiceApolice : ServiceBase<Apolice>, IServiceApolice
    {
        private readonly IRepositoryApolice repositoryApolice;

        public ServiceApolice(IRepositoryApolice repositoryApolice)
            : base(repositoryApolice)
        {
            this.repositoryApolice = repositoryApolice;
        }
    }
}