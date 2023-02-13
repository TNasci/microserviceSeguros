using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoMapper;
using microserviceSeguros.Application;
using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Domain.Core.Interfaces.Services;
using microserviceSeguros.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace microserviceSeguros.Tests.Services
{
    public class ApplicationServicesApoliceTests
    {
        private static Fixture _fixture;
        private Mock<IServiceApolice> _serviceApoliceMock;
        private Mock<IMapper> _mapperMock;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _serviceApoliceMock = new Mock<IServiceApolice>();
            _mapperMock = new Mock<IMapper>();
        }
    }
}

