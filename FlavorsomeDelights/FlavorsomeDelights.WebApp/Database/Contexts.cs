using FlavorsomeDelights.WebApp.Models;
using System.Data.Entity;

namespace FlavorsomeDelights.WebApp.Database
{
    public class Contexts : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipesIngredients { get; set; }

    }

}
