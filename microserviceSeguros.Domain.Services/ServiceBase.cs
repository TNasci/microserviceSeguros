using microserviceSeguros.Domain.Core.Interfaces.Repositorys;
using microserviceSeguros.Domain.Core.Interfaces.Services;

namespace microserviceSeguros.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public virtual void Delete(TEntity obj)
        {
            repository.Delete(obj);
        }

        public virtual void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}