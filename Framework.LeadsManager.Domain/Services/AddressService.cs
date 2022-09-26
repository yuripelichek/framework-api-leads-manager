using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;

namespace Framework.LeadsManager.Domain.Services
{
    public class AddressService : Service<Address>, IAddressService
    {
        private readonly IAddressRepository Repository;

        public AddressService(IAddressRepository repository) : base(repository) => Repository = repository;
    }
}
