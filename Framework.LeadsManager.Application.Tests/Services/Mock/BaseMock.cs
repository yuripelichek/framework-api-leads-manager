using AutoMapper;
using Framework.LeadsManager.Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Moq;
using Moq.AutoMock;

namespace Framework.LeadsManager.Application.Tests.Services.Mock
{
    public abstract class BaseMock<TService> where TService : class
    {
        public readonly AutoMocker AutoMocker;

        protected BaseMock()
        {
            AutoMocker = new AutoMocker();
        }
        public Mock<IConfiguration> GetConfiguration() => AutoMocker.GetMock<IConfiguration>();
        public Mock<ILeadService> GetLeadServiceMock() => AutoMocker.GetMock<ILeadService>();
        public Mock<IMapper> GetMapperMock() => AutoMocker.GetMock<IMapper>();
    }
}