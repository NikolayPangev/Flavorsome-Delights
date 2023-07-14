using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Database
{
    public class Contexts : DbContext
    {

        public Contexts(DbContextOptions<Contexts>options):base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Collection> Collections { get; set; } = null!;
        public DbSet<Favorite> Favorites { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<RecipeIngredient> RecipesIngredients { get; set; } = null!;
    }
    
}
