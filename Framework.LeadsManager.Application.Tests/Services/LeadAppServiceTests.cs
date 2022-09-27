using Framework.LeadsManager.Application.Services;
using Framework.LeadsManager.Application.Tests.Services.Fixture;
using Framework.LeadsManager.Application.Tests.Services.Mock;
using Framework.LeadsManager.Domain.Entities;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Framework.LeadsManager.Application.Tests.Services
{
    public class LeadAppServiceTests : IClassFixture<LeadAppServiceFixture>
    {
        private readonly LeadAppServiceFixture _fixture;
        private readonly LeadAppServiceMock _mock;

        public LeadAppServiceTests(LeadAppServiceFixture fixture)
        {
            _fixture = fixture;
            _mock = new LeadAppServiceMock(fixture);
        }

        [Fact]
        public async Task AcceptLeadAsync_Should_Be_True()
        {
            //Arrange

            var mapper = _mock.GetMapperMock().Object;
            var leadService = _mock.GetLeadServiceMock().Object;

            var appService = new LeadAppService(leadService, mapper);

            Mock<Lead> leadReturn = new();
            _mock.GetLeadServiceMock()
                 .Setup(d => d.GetById(It.IsAny<int>()))
                 .ReturnsAsync(leadReturn.Object);

            try
            {
                // Act
                await appService.AcceptLeadAsync(1);

                //Assert
                Assert.True(true);
            }
            catch
            {
                //Assert
                Assert.True(false);
            }
        }
    }
}