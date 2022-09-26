namespace Framework.LeadsManager.Domain.Entities
{
    public class Address : Entity
    {
        public int ClientId { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string GetSuburb() => $"{Neighborhood} {Number}";
        public virtual Client Client { get; private set; }
    }
}
