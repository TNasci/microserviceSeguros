using AutoMapper;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Mappers
{
    public class ModelToDTOMappingPagamento : Profile
    {
        public ModelToDTOMappingPagamento()
        {
            PagamentoDTOMap();
        }

        private void PagamentoDTOMap()
        {
            CreateMap<Pagamento, PagamentoDTO>()
                .ForMember(dest => dest.dataPago, opt => opt.MapFrom(x => x.dataPago))
                .ForMember(dest => dest.data_pagamento, opt => opt.MapFrom(x => x.data_pagamento))
                .ForMember(dest => dest.tipo, opt => opt.MapFrom(x => x.tipo));
        }
    }
}