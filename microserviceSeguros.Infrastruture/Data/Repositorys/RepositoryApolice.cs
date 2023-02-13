using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

        public override IEnumerable<Apolice> GetAll()
        {
            return sqlContext.Apolice.Include(a => a.parcelas).ToList();
        }

        public override Apolice GetById(int id)
        {
            return sqlContext.Apolice.Include(a => a.parcelas).FirstOrDefault(b => b.Id == id);
        }
    }
}