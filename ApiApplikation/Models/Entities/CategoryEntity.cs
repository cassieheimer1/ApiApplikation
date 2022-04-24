using System.ComponentModel.DataAnnotations;

namespace ApiApplikation.Models.Entities
{
    public class CategoryEntity
    { 

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductEntity> Products { get; set; } = null!;
    }
}

