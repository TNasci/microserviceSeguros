using AutoMapper;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application
{
    public class ApplicationServicePagamento : IApplicationServicePagamento
    {
        private readonly IServicePagamento servicePagamento;
        private readonly IMapper mapper;

        public ApplicationServicePagamento(IServicePagamento servicePagamento, IMapper mapper)
        {
            this.servicePagamento = servicePagamento;
            this.mapper = mapper;
        }

        public PagamentoDTO CacularJuros(PagamentoDTO pagamentosDTO)
        {
            var pagamento = mapper.Map<Pagamento>(pagamentosDTO);
            var calculo = servicePagamento.CalcularJuros(pagamento);
            var pagamentoDTO = mapper.Map<PagamentoDTO>(calculo);

            return pagamentoDTO;
        }
    }
}