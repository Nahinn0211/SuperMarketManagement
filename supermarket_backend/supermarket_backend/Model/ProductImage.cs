namespace supermarket_backend.Model
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string? UrlImage { get; set; }
        public int Main {  get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
