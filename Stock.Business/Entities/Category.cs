using System.Collections.Generic;

namespace Stock.Business.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
