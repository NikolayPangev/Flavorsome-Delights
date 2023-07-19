namespace FlavorsomeDelights.WebApp.Models
{
    public class RecipeDetailedItem
    {
        public int Id { get; set; }
        public string HowToPrepare{ get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Complexity { get; set; } = null!;
        public int Serves { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
