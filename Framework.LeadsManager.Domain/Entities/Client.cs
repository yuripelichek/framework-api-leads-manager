using System.Collections.Generic;

namespace Framework.LeadsManager.Domain.Entities
{
    public class Client : Entity
    {
        public string Name { get;  set; }
        public string LastName { get; set; }
        public string GetFullName() => $"{Name} {LastName}";
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual Address Addreess { get; set; }
        public virtual IEnumerable<Lead> Lead { get; set; }
    }
}
