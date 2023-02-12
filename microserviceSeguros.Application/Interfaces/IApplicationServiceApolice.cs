using microserviceSeguros.Application.DTOs;

namespace microserviceSeguros.Application.Interfaces
{
    public interface IApplicationServiceApolice
    {
        void Add(ApoliceDTO apoliceDTO);

        void Update(ApoliceDTO apoliceDTO);

        void Delete(ApoliceDTO apoliceDTO);

        IEnumerable<ApoliceDTO> GetAll();

        ApoliceDTO GetById(int id);
    }
}