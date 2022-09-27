using Framework.LeadsManager.Application.Interfaces;
using Framework.LeadsManager.Application.Tests.Services.Fixture;
using Moq;

namespace Framework.LeadsManager.Application.Tests.Services.Mock
{
    public class LeadAppServiceMock : BaseMock<ILeadAppService>
    {
        private readonly LeadAppServiceFixture _fixture;
        public Mock<ILeadAppService> MockLeadAppService;
        public LeadAppServiceMock(LeadAppServiceFixture fixture)
        {
            _fixture = fixture;
            MockLeadAppService = new Mock<ILeadAppService>();
        }
    }
}