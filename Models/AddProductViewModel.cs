using System.ComponentModel.DataAnnotations;

namespace Lesson8Task_.Models
{
    public class AddProductViewModel
    {
        [Required]
        [MinLength(2)]
        public string Title { get; set; }
        [Required]
        [MinLength(2)]
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? ImageUrl { get; set; }

    }
}
