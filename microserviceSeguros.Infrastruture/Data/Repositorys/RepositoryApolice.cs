using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Infrastruture.Data.Repositorys
{
    public class RepositoryApolice : RepositoryBase<Apolice>, IRepositoryApolice
    {
        private readonly SqlContext sqlContext;

        public RepositoryApolice(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}