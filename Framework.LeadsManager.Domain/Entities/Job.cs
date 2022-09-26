namespace Framework.LeadsManager.Domain.Entities
{
    public class Job : Entity
    {
        public Job() { }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceWithDiscount { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Lead Lead { get; set; }
    }
}
