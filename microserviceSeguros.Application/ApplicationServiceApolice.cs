using AutoMapper;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application
{
    public class ApplicationServiceApolice : IApplicationServiceApolice
    {
        private readonly IServiceApolice serviceApolice;
        private readonly IMapper mapper;

        public ApplicationServiceApolice(IServiceApolice serviceApolice, IMapper mapper)
        {
            this.serviceApolice = serviceApolice;
            this.mapper = mapper;
        }

        public void Add(ApoliceDTO apoliceDTO)
        {
            var apolice = mapper.Map<Apolice>(apoliceDTO);
            serviceApolice.Add(apolice);
        }

        public IEnumerable<ApoliceDTO> GetAll()
        {
            var apolices = serviceApolice.GetAll();
            var apoliceDTO = mapper.Map<IEnumerable<ApoliceDTO>>(apolices);
            return apoliceDTO;
        }

        public ApoliceDTO GetById(int id)
        {
            var apolice = serviceApolice.GetById(id);
            var apoliceDTO = mapper.Map<ApoliceDTO>(apolice);
            return apoliceDTO;
        }

        public void Delete(ApoliceDTO apoliceDTO)
        {
            var apolice = mapper.Map<Apolice>(apoliceDTO);
            serviceApolice.Delete(apolice);
        }

        public void Update(ApoliceDTO apoliceDTO)
        {
            var apolice = mapper.Map<Apolice>(apoliceDTO);
            serviceApolice.Update(apolice);
        }
    }
}