using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Domain.Core.Interfaces.Services;

namespace microserviceSeguros.Application
{
    public class ApplicationServicePagamento : IApplicationServicePagamento
    {
        private readonly IServicePagamento servicePagamento;
        private readonly IMapperPagamento mapperPagamento;

        public ApplicationServicePagamento(IServicePagamento servicePagamento, IMapperPagamento mapperPagamento)
        {
            this.servicePagamento = servicePagamento;
            this.mapperPagamento = mapperPagamento;
        }

        public PagamentoDTO CacularJuros(PagamentoDTO pagamentoDTO)
        {
            var pagamento = mapperPagamento.MapperDTOToEntity(pagamentoDTO);
            var calculo = servicePagamento.CalcularJuros(pagamento);

            return mapperPagamento.MapperEntityToDTO(calculo);
        }
    }
}