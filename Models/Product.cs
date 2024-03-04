namespace Lesson8Task_.Models
{
    public class Product :BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }

   
}
