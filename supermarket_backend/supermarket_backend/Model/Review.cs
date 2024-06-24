namespace supermarket_backend.Model
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
        public string? Description { get; set; }
    }
}
