using System.Collections.Generic;

namespace Framework.LeadsManager.Domain.Entities
{
    public class Client : Entity
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string GetFullName() => $"{Name} {LastName}";
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public virtual Address Addreess { get; private set; }
        public virtual IEnumerable<Lead> Lead { get; private set; }
    }
}
