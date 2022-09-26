namespace Framework.LeadsManager.Domain.Entities
{
    public class Job : Entity
    {
        public Job() { }
        //public Job(int categoryId, decimal price)
        //{
        //    CategoryId = categoryId;
        //    Price = price;  
        //}
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceWithDiscount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Lead Lead { get; set; }
    }
}
