namespace FlavorsomeDelights.WebApp.Models
{
    public class RecipeListItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Complexity { get; set; } = null!;
        public int Serves { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
