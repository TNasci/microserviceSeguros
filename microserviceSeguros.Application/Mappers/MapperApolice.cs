using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Mappers
{
    public class MapperApolice : IMapperApolice
    {
        public Apolice MapperDTOToEntity(ApoliceDTO apoliceDTO)
        {
            var apolice = new Apolice()
            {
                Id = apoliceDTO.Id,
                descricao = apoliceDTO.descricao,
                cpf = apoliceDTO.cpf,
                situacao = apoliceDTO.situacao,
                premio_total = (decimal)apoliceDTO.premio_total,
                data_criacao_registro = apoliceDTO.data_criacao_registro,
                data_alteracao_registro = apoliceDTO.data_alteracao_registro,
                usuario_criacao_registro = apoliceDTO.usuario_criacao_registro,
                usuario_alteracao_registro = apoliceDTO.usuario_alteracao_registro,
                parcelas = new List<Parcela>()
            };

            if (apoliceDTO.parcelas != null && apoliceDTO.parcelas.Any())
            {
                apoliceDTO.parcelas.ForEach(parcela =>
                {
                    var parc = new Parcela();
                    parc.premio = parcela.premio;
                    parc.forma_pagamento = parcela.forma_pagamento;
                    parc.data_pagamento = parcela.data_pagamento;
                    parc.data_pago = parcela.data_pago;
                    parc.juros = parcela.juros;
                    parc.situacao = parcela.situacao;
                    parc.data_criacao_registro = parcela.data_criacao_registro;
                    parc.data_alteracao_registro = parcela.data_alteracao_registro;
                    parc.usuario_criacao_registro = parcela.usuario_criacao_registro;
                    parc.usuario_alteracao_registro = parcela.usuario_alteracao_registro;

                    apolice.parcelas.Add(parc);
                });
            }

            return apolice;
        }

        public ApoliceDTO MapperEntityToDTO(Apolice apolice)
        {
            var apoliceDTO = new ApoliceDTO()
            {
                Id = apolice.Id,
                descricao = apolice.descricao,
                cpf = apolice.cpf,
                situacao = apolice.situacao,
                premio_total = (float)apolice.premio_total,
                data_criacao_registro = apolice.data_criacao_registro,
                data_alteracao_registro = apolice.data_alteracao_registro,
                usuario_criacao_registro = apolice.usuario_criacao_registro,
                usuario_alteracao_registro = apolice.usuario_alteracao_registro
            };

            return apoliceDTO;
        }

        public IEnumerable<ApoliceDTO> MapperListApoliceDTO(IEnumerable<Apolice> apolices)
        {
            var dto = apolices.Select(a => new ApoliceDTO
            {
                Id = a.Id,
                descricao = a.descricao,
                cpf = a.cpf,
                situacao = a.situacao,
                premio_total = (float)a.premio_total,
                data_criacao_registro = a.data_criacao_registro,
                data_alteracao_registro = a.data_alteracao_registro,
                usuario_criacao_registro = a.usuario_criacao_registro,
                usuario_alteracao_registro = a.usuario_alteracao_registro
            });
            return dto;
        }
    }
}