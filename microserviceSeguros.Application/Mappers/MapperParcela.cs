using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Mappers
{
    public class MapperParcela : IMapperParcela
    {
        public Parcela MapperDTOToEntity(ParcelaDTO parcelasDTO)
        {
            var parcelas = new Parcela()
            {
                Id = parcelasDTO.Id,
                apoliceId = parcelasDTO.apoliceId,
                premio = (decimal)parcelasDTO.premio,
                forma_pagamento = parcelasDTO.forma_pagamento,
                data_pagamento = parcelasDTO.data_pagamento,
                data_pago = parcelasDTO.data_pago,
                juros = (decimal)parcelasDTO.juros,
                situacao = parcelasDTO.situacao,
                data_criacao_registro = parcelasDTO.data_criacao_registro,
                data_alteracao_registro = parcelasDTO.data_alteracao_registro,
                usuario_criacao_registro = parcelasDTO.usuario_criacao_registro,
                usuario_alteracao_registro = parcelasDTO.usuario_alteracao_registro
            };

            return parcelas;
        }

        public ParcelaDTO MapperEntityToDTO(Parcela parcelas)
        {
            var parcelasDTO = new ParcelaDTO()
            {
                Id = parcelas.Id,
                apoliceId = parcelas.apoliceId,
                premio = (decimal)parcelas.premio,
                forma_pagamento = parcelas.forma_pagamento,
                data_pagamento = parcelas.data_pagamento,
                data_pago = parcelas.data_pago,
                juros = (decimal)parcelas.juros,
                situacao = parcelas.situacao,
                data_criacao_registro = parcelas.data_criacao_registro,
                data_alteracao_registro = parcelas.data_alteracao_registro,
                usuario_criacao_registro = parcelas.usuario_criacao_registro,
                usuario_alteracao_registro = parcelas.usuario_alteracao_registro
            };

            return parcelasDTO;
        }

        public IEnumerable<ParcelaDTO> MapperListParcelasDTOs(IEnumerable<Parcela> parcelas)
        {
            var dto = parcelas.Select(p => new ParcelaDTO
            {
                Id = p.Id,
                apoliceId = p.apoliceId,
                premio = (decimal)p.premio,
                forma_pagamento = p.forma_pagamento,
                data_pagamento = p.data_pagamento,
                data_pago = p.data_pago,
                juros = (decimal)p.juros,
                situacao = p.situacao,
                data_criacao_registro = p.data_criacao_registro,
                data_alteracao_registro = p.data_alteracao_registro,
                usuario_criacao_registro = p.usuario_criacao_registro,
                usuario_alteracao_registro = p.usuario_alteracao_registro
            });
            return dto;
        }
    }
}