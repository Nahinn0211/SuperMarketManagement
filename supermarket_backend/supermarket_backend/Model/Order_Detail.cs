namespace supermarket_backend.Model
{
    public class Order_Detail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }

        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
