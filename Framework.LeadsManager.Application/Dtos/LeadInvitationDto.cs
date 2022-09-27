using System;

namespace Framework.LeadsManager.Application.Dtos
{
    public class LeadInvitationDto
    {
        public int LeadId { get; set; }
        public int JobId { get; set; }
        public string ClientFirstName { get; set; }
        public string Suburb { get; set; }
        public string JobDescription { get; set; }
        public string CategoryDescription { get; set; }
        public decimal Price { get; set; }
        public DateTime JobDateCreation { get; set; }
    }
}
