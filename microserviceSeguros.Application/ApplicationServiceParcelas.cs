using AutoMapper;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;

namespace microserviceSeguros.Application
{
    public class ApplicationServiceParcelas : IApplicationServiceParcela
    {
        private readonly IServiceParcela serviceParcelas;
        private readonly IMapper mapper;

        public ApplicationServiceParcelas(IServiceParcela serviceParcelas, IMapper mapper)
        {
            this.serviceParcelas = serviceParcelas;
            this.mapper = mapper;
        }

        public void Add(ParcelaDTO parcelasDTO)
        {
            var parcelas = mapper.Map<Parcela>(parcelasDTO);
            serviceParcelas.Add(parcelas);
        }

        public IEnumerable<ParcelaDTO> GetAll()
        {
            var parcelas = serviceParcelas.GetAll();
            return mapper.Map<IEnumerable<ParcelaDTO>>(parcelas);
        }

        public ParcelaDTO GetById(int id)
        {
            var parcela = serviceParcelas.GetById(id);
            var parcelaDTO = mapper.Map<ParcelaDTO>(parcela);
            return parcelaDTO;
        }

        public void Delete(ParcelaDTO parcelasDTO)
        {
            var parcela = mapper.Map<Parcela>(parcelasDTO);
            serviceParcelas.Delete(parcela);
        }

        public void Update(ParcelaDTO parcelasDTO)
        {
            var parcela = mapper.Map<Parcela>(parcelasDTO);
            serviceParcelas.Update(parcela);
        }
    }
}