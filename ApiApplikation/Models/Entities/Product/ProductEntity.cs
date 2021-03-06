using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiApplikation.Models.Entities
{
    public class ProductEntity
    {
        public ProductEntity()
        {
        }
        public ProductEntity(string name, decimal price, int categoryId)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; } = null!;

        public int ArticalNumber { get; set; }
        public string Description { get; set; } = null!;

    }
}
