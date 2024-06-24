namespace supermarket_backend.Model
{
    public class Attribute_Value
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public int Quantity {get; set;}
        public decimal PriceIn {get; set;}
        public decimal PriceOut { get; set; }
        public int AttributeId {get; set;}
        public Attribute? Attribute {get; set;}
    }
}
