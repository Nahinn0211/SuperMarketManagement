namespace supermarket_backend.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }

        public Brand? Brand { get; set; }
        public Category? Category { get; set; }
        public ICollection<Attribute_Product>? Attribute_Products { get; set; }
        public ICollection<ProductImage>? ProductImages { get; set; }
        public ICollection<Order_Detail>? Order_Details { get; set; }
    }
}
