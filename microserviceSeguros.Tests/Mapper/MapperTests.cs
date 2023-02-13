using AutoMapper;
using microserviceSeguros.Application.Mappers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microserviceSeguros.Tests.Mapper
{
    [TestFixture]
    public class MapperTests
    {
        [Test]
        public void AutoMapperDTOToModelApolice_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<DTOToModelMappingApolice>());
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapperModelToDTOApolice_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ModelToDTOMappingApolice>());
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapperDTOToModelParcela_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<DTOToModelMappingParcela>());
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapperModelToDTOParcela_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ModelToDTOMappingParcela>());
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapperDTOToModelPagamento_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<DTOToModelMappingPagamento>());
            config.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapperModelToDTOPagamento_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<ModelToDTOMappingPagamento>());
            config.AssertConfigurationIsValid();
        }

    }
}
