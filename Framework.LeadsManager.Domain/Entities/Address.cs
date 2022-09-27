namespace Framework.LeadsManager.Domain.Entities
{
    public class Address : Entity
    {
        public int ClientId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string GetSuburb() => $"{Neighborhood} {Number}";
        public virtual Client Client { get; set; }
    }
}
