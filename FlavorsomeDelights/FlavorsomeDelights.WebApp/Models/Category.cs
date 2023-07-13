using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        public string Type { get; set; } = null!;
        [Required]
        public string CategoryImageUrl { get; set; } = null!;
    }
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}


