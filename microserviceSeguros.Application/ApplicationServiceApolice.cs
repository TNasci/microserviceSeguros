using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Domain.Core.Interfaces.Services;

namespace microserviceSeguros.Application
{
    public class ApplicationServiceApolice : IApplicationServiceApolice
    {
        private readonly IServiceApolice serviceApolice;
        private readonly IMapperApolice mapperApolice;

        public ApplicationServiceApolice(IServiceApolice serviceApolice, IMapperApolice mapperApolice)
        {
            this.serviceApolice = serviceApolice;
            this.mapperApolice = mapperApolice;
        }

        public void Add(ApoliceDTO apoliceDTO)
        {
            var apolice = mapperApolice.MapperDTOToEntity(apoliceDTO);
            serviceApolice.Add(apolice);
        }

        public IEnumerable<ApoliceDTO> GetAll()
        {
            var apolices = serviceApolice.GetAll();
            return mapperApolice.MapperListApoliceDTO(apolices);
        }

        public ApoliceDTO GetById(int id)
        {
            var apolice = serviceApolice.GetById(id);
            return mapperApolice.MapperEntityToDTO(apolice);
        }

        public void Delete(ApoliceDTO apoliceDTO)
        {
            var apolice = mapperApolice.MapperDTOToEntity(apoliceDTO);
            serviceApolice.Delete(apolice);
        }

        public void Update(ApoliceDTO apoliceDTO)
        {
            var apolice = mapperApolice.MapperDTOToEntity(apoliceDTO);
            serviceApolice.Update(apolice);
        }
    }
}