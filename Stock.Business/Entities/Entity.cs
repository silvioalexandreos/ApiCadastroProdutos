using System;

namespace Stock.Business.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
