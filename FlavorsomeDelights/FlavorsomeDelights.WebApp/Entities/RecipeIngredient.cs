using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlavorsomeDelights.WebApp.Models
{
    public class RecipeIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeIngredientId { get; set; }

        [Required]
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; } = null!;

        [Required]
        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

    }
}
