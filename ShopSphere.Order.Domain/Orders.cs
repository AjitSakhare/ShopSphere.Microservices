namespace ShopSphere.Order.Domain
{
    public class Orders
    {
        public int Id { get; set; }

        public string ProductId { get; set; }

        public decimal Amount { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
