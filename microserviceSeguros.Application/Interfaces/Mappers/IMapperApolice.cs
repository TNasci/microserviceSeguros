using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Interfaces.Mappers
{
    public interface IMapperApolice
    {
        Apolice MapperDTOToEntity(ApoliceDTO apoliceDTO);

        IEnumerable<ApoliceDTO> MapperListApoliceDTO(IEnumerable<Apolice> apolices);

        ApoliceDTO MapperEntityToDTO(Apolice apolice);
    }
}