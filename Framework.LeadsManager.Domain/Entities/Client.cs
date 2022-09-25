using System.Collections.Generic;

namespace Framework.LeadsManager.Domain.Entities
{
    public class Client : Entity
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Address Addreess { get; private set; }
        public IEnumerable<Lead> Lead { get; private set; }
    }
}
