using System;

namespace Stock.Business.Entities
{
    public class Product : Entity
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SupplierId { get; set; }
        public string Description { get; set; }

        public virtual Category Category { get; set; }
    }
}
