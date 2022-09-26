namespace Framework.LeadsManager.Domain.Entities
{
    public class Lead : Entity
    {
        public int ClientId { get; set; }
        public int JobId { get; set; }
        public Job Job { get; private set; }
        public Client Client { get; set; }
        public bool Approved { get; set; }
    }
}