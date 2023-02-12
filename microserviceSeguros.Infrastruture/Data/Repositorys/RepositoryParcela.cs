using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Infrastruture.Data.Repositorys
{
    public class RepositoryParcela : RepositoryBase<Parcela>, IRepositoryParcela
    {
        private readonly SqlContext sqlContext;

        public RepositoryParcela(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}