using AutoMapper;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application.Mappers
{
    public class ModelToDTOMappingApolice : Profile
    {
        public ModelToDTOMappingApolice()
        {
            ApoliceDTOMap();
        }

        private void ApoliceDTOMap()
        {
            CreateMap<Apolice, ApoliceDTO>()
                .ForMember(dest => dest.descricao, opt => opt.MapFrom(x => x.descricao))
                .ForMember(dest => dest.cpf, opt => opt.MapFrom(x => x.cpf))
                .ForMember(dest => dest.situacao, opt => opt.MapFrom(x => x.situacao))
                .ForMember(dest => dest.premio_total, opt => opt.MapFrom(x => x.premio_total))
                .ForMember(dest => dest.data_criacao_registro, opt => opt.Ignore())
                .ForMember(dest => dest.data_alteracao_registro, opt => opt.Ignore())
                .ForMember(dest => dest.usuario_criacao_registro, opt => opt.MapFrom(x => x.usuario_criacao_registro))
                .ForMember(dest => dest.usuario_alteracao_registro, opt => opt.MapFrom(x => x.usuario_alteracao_registro))
                .ForMember(dest => dest.parcelas, opt => opt.MapFrom(x => x.parcelas));
        }
    }
}