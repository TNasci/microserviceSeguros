using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Interfaces.Mappers
{
    public interface IMapperPagamento
    {
        Pagamento MapperDTOToEntity(PagamentoDTO pagamentoDTO);

        PagamentoDTO MapperEntityToDTO(Pagamento pagamento);
    }
}