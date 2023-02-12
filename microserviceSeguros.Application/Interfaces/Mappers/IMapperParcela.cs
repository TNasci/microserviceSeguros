using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Interfaces.Mappers
{
    public interface IMapperParcela
    {
        Parcela MapperDTOToEntity(ParcelaDTO parcelasDTO);

        IEnumerable<ParcelaDTO> MapperListParcelasDTOs(IEnumerable<Parcela> parcelas);

        ParcelaDTO MapperEntityToDTO(Parcela parcelas);
    }
}