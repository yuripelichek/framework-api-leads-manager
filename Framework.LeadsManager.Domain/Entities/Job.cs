using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Entities
{
    public class Job : Entity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceWithDiscount{ get; set; }
        public int LeadId { get; set; }
        public int CategoryId { get; set; }
        public Lead Lead { get; set; }
        public Category Category { get; set; }
    }
}
