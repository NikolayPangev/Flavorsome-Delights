using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

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

        [Required]
        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }
    }
}
