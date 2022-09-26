using System;

namespace Framework.LeadsManager.Application.Dtos
{
    public class LeadAcceptedDto
    {        
        public string ClientFullName { get; set; }
        public DateTime JobDateCreation { get; set; }
        public string Suburb { get; set; }
        public string CategoryDescription { get; set; }
        public int JobId { get; set; }
        public decimal FinalPrice { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string JobDescription { get; set; }
    }
}
