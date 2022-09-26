namespace Framework.LeadsManager.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Job Job { get; set; }
    }
}
