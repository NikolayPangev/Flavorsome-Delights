using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Favorite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavoriteId { get; set; }

        [Required]
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

        [Required]
        [ForeignKey("Collection")]
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }
    }
    public class FavoriteContext : DbContext
    {
        public DbSet<Favorite> Favorites { get; set; }
    }
}
