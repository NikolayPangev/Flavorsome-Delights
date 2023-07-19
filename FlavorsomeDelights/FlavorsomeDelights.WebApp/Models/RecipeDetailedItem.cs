namespace FlavorsomeDelights.WebApp.Models
{
    public class RecipeDetailedItem
    {
        public int RecipeId { get; set; }
        public string Title { get; set; } = null!;
        public List<IngredientItem> Ingredients { get; set; } = null!;
        public string HowToPrepare{ get; set; } = null!;
        public string Complexity { get; set; } = null!;
        public int Serves { get; set; }
        public string ImageUrl { get; set; } = null!;

    }
}
