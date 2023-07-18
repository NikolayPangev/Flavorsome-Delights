using FlavorsomeDelights.WebApp.Database;
using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Repository
{
    public class RecipeRepository
    {
        private readonly Contexts _context;

        public RecipeRepository(Contexts context)
        {
            _context = context;
        }

        public List<RecipeListItem> GetAllRecipes()
        {
            return _context.Recipes.Select(r => new RecipeListItem
            {
                Id = r.RecipeId,
                Title = r.Title,
                Complexity = r.Complexity,
                Serves = r.Serves,
                ImageUrl = r.ImageUrl
            }
            ).ToList();
        }
    }
}
