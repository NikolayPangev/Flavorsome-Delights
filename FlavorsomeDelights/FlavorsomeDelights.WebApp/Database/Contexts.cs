using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Database
{
    public class Contexts : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Collection> Collections { get; set; } = null!;
        public DbSet<Favorite> Favorites { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<RecipeIngredient> RecipesIngredients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Read connection string from app config
            //Pass value to method
            optionsBuilder.UseSqlServer(new ConfigurationManager().GetConnectionString("Server=.\\SQLEXPRESS;Database=FlavorsomeDelights;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }
    }
    
}
