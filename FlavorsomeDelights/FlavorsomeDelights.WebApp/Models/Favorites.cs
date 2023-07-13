using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Favorite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavoriteId { get; set; }

        public int RecipeId { get; set; }
        [ForeignKey("Recipe")]
        public virtual Recipe Recipe { get; set; }
        [ForeignKey("Collection")]
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }
    }
}
