using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Recipies_Ingredients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeIngredientId { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }
    }
}
