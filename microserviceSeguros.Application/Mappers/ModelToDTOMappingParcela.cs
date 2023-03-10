using AutoMapper;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Mappers
{
    public class ModelToDTOMappingParcela : Profile
    {
        public ModelToDTOMappingParcela()
        {
            ParcelaDTOMap();
        }

        private void ParcelaDTOMap()
        {
            CreateMap<Parcela, ParcelaDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.apoliceId, opt => opt.MapFrom(x => x.apoliceId))
                .ForMember(dest => dest.premio, opt => opt.MapFrom(x => x.premio))
                .ForMember(dest => dest.forma_pagamento, opt => opt.MapFrom(x => x.forma_pagamento))
                .ForMember(dest => dest.data_pagamento, opt => opt.MapFrom(x => x.data_pagamento))
                .ForMember(dest => dest.data_pago, opt => opt.MapFrom(x => x.data_pago))
                .ForMember(dest => dest.juros, opt => opt.MapFrom(x => x.juros))
                .ForMember(dest => dest.situacao, opt => opt.MapFrom(x => x.situacao))
                .ForMember(dest => dest.data_criacao_registro, opt => opt.Ignore())
                .ForMember(dest => dest.data_alteracao_registro, opt => opt.Ignore())
                .ForMember(dest => dest.usuario_criacao_registro, opt => opt.MapFrom(x => x.usuario_criacao_registro))
                .ForMember(dest => dest.usuario_alteracao_registro, opt => opt.MapFrom(x => x.usuario_alteracao_registro));
        }
    }
}