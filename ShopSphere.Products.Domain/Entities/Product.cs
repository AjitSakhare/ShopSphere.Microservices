using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Products.Domain.Entities
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
