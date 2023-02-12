using microserviceSeguros.Application.DTOs;

namespace microserviceSeguros.Application.Interfaces
{
    public interface IApplicationServiceParcela
    {
        void Add(ParcelaDTO parcelasDTO);

        void Update(ParcelaDTO parcelasDTO);

        void Delete(ParcelaDTO parcelasDTO);

        IEnumerable<ParcelaDTO> GetAll();

        ParcelaDTO GetById(int id);
    }
}