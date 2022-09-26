namespace Framework.LeadsManager.Application.Dtos
{
    public class LeadDto
    {
        public int ClientId { get; set; }
        public int JobId { get; set; }
        public bool? Approved { get; set; }
    }
}
