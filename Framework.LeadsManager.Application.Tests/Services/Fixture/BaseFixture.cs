using AutoFixture;

namespace Framework.LeadsManager.Application.Tests.Services.Fixture
{
    public abstract class BaseFixture
    {
        public IFixture SpecimenBuilder { get; }

        protected BaseFixture() => SpecimenBuilder = new AutoFixture.Fixture();
    }
}