namespace Framework.LeadsManager.Domain.Entities
{
    public class Lead : Entity
    {
        public Lead() { }
        //public Lead(int jobId, int clientId)
        //{
        //    JobId = jobId;
        //    ClientId = clientId;
        //}
        public bool? Approved { get; set; }
        public int JobId { get; set; }
        public int ClientId { get; set; }
        public Job Job { get; set; }
        public Client Client { get; set; }
    }
}