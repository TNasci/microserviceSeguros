using microserviceSeguros.Application.DTOs;

namespace microserviceSeguros.Application.Interfaces
{
    public interface IApplicationServicePagamento
    {
        PagamentoDTO CacularJuros(PagamentoDTO pagamentoDTO);
    }
}