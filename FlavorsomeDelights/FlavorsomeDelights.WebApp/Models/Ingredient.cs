using System.ComponentModel.DataAnnotations;

namespace FlavorsomeDelights.WebApp.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        [Required]
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public bool isAllergic { get; set; }
    }
}
