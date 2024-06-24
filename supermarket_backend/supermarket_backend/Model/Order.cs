namespace supermarket_backend.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string? Description { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public ICollection<Order_Detail>? Order_Details { get; set; }
    }
}
