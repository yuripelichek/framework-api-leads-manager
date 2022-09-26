using System;

namespace Framework.LeadsManager.Domain.Entities
{
    public class Entity
    {
        public int Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime? ModifiedAt { get; protected set; }
    }
}
