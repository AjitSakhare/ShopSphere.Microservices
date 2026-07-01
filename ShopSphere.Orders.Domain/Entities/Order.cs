using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Orders.Domain.Entities
{
    public class Orders
    {
        public int Id { get; set; }

        public string ProductsId { get; set; }

        public decimal Amount { get; set; }

        public DateTime OrdersDate { get; set; }
    }
}
