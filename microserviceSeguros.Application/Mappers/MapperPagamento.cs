using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Mappers
{
    public class MapperPagamento : IMapperPagamento
    {
        public Pagamento MapperDTOToEntity(PagamentoDTO pagamentoDTO)
        {
            var pagamento = new Pagamento()
            {
                dataPago = pagamentoDTO.dataPago,
                data_pagamento = pagamentoDTO.data_pagamento,
                tipo = pagamentoDTO.tipo,
                total_juros = pagamentoDTO.total_juros
            };

            return pagamento;
        }

        public PagamentoDTO MapperEntityToDTO(Pagamento pagamento)
        {
            var pagamentoDTO = new PagamentoDTO()
            {
                dataPago = pagamento.dataPago,
                data_pagamento = pagamento.data_pagamento,
                tipo = pagamento.tipo,
                total_juros = pagamento.total_juros
            };

            return pagamentoDTO;
        }
    }
}