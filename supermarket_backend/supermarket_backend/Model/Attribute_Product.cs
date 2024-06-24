namespace supermarket_backend.Model
{
    public class Attribute_Product
    {
        public int Id {get; set;}
        public int ProductId {get; set;}
        public int AttributeId {get; set;}

        public Product? Product { get; set; }
        public Attribute? Attribute { get; set; }
    }
}
