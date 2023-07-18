using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Database
{
    public class Contexts : DbContext
    {

        public Contexts(DbContextOptions<Contexts> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Collection> Collections { get; set; } = null!;
        public DbSet<Favorite> Favorites { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<RecipeIngredient> RecipesIngredients { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<RecipeIngredient>()
                .HasIndex(i => i.RecipeIngredientId)
                .IsUnique();

            modelBuilder
                .Entity<Recipe>()
                .HasIndex(i => i.RecipeId)
                .IsUnique();

            modelBuilder
                .Entity<Ingredient>()
                .HasIndex(i => i.IngredientId)
                .IsUnique();

            modelBuilder
                .Entity<Favorite>()
                .HasIndex(i => i.FavoriteId)
                .IsUnique();

            modelBuilder
                .Entity<Collection>()
                .HasIndex(i => i.CollectionId)
                .IsUnique();

            modelBuilder
                .Entity<Category>()
                .HasIndex(i => i.CategoryId)
                .IsUnique();

            modelBuilder
                .Entity<Ingredient>()
                .HasIndex(i => i.Name)
                .IsUnique();

            modelBuilder
                .Entity<Category>()
                .HasIndex(i => i.Type)
                .IsUnique();

            modelBuilder
                .Entity<Collection>()
                .HasIndex(i => i.Type)
                .IsUnique();
        }
    }

}
