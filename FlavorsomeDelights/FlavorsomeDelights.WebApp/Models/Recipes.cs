namespace FlavorsomeDelights.WebApp.Models
{
    public class Recipes
    {
        public List<RecipeListItem> Items { get; set; } = null!;
        public List<RecipeDetailedItem> RecipeDetailedItems { get; set; } = null!;
    }
}
