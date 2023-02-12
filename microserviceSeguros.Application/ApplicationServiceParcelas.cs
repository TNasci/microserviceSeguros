using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Application.Interfaces.Mappers;
using microserviceSeguros.Domain.Core.Interfaces.Services;

namespace microserviceSeguros.Application
{
    public class ApplicationServiceParcelas : IApplicationServiceParcela
    {
        private readonly IServiceParcela serviceParcelas;
        private readonly IMapperParcela mapperParcelas;

        public ApplicationServiceParcelas(IServiceParcela serviceParcelas, IMapperParcela mapperParcelas)
        {
            this.serviceParcelas = serviceParcelas;
            this.mapperParcelas = mapperParcelas;
        }

        public void Add(ParcelaDTO parcelasDTO)
        {
            var parcelas = mapperParcelas.MapperDTOToEntity(parcelasDTO);
            serviceParcelas.Add(parcelas);
        }

        public IEnumerable<ParcelaDTO> GetAll()
        {
            var parcelas = serviceParcelas.GetAll();
            return mapperParcelas.MapperListParcelasDTOs(parcelas);
        }

        public ParcelaDTO GetById(int id)
        {
            var parcela = serviceParcelas.GetById(id);
            return mapperParcelas.MapperEntityToDTO(parcela);
        }

        public void Delete(ParcelaDTO parcelasDTO)
        {
            var parcela = mapperParcelas.MapperDTOToEntity(parcelasDTO);
            serviceParcelas.Delete(parcela);
        }

        public void Update(ParcelaDTO parcelasDTO)
        {
            var parcela = mapperParcelas.MapperDTOToEntity(parcelasDTO);
            serviceParcelas.Update(parcela);
        }
    }
}