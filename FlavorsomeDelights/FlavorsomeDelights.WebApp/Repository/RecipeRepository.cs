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

        public List<RecipeListItem> GetAllRecipesByComplexity(string chosenDifficulty)
        {
            return _context.Recipes.Where(r => r.Complexity == chosenDifficulty).Select(r => new RecipeListItem
        {
                Id = r.RecipeId,
                Title = r.Title,
                Complexity = r.Complexity,
                Serves = r.Serves,
                ImageUrl = r.ImageUrl
            }
            ).ToList();
        }
        public List<RecipeListItem> GetAllRecipesByCategory(string chosenCategory)
        {
            return _context.Recipes.Where(r => r.Category.Type == chosenCategory).Select(r => new RecipeListItem
            {
                Id = r.RecipeId,
                Title = r.Title,
                Complexity = r.Complexity,
                Serves = r.Serves,
                ImageUrl = r.ImageUrl
            }
            ).ToList();
        }
        public List<RecipeDetailedItem> GetRecipeDetails()
        {
            return _context.Recipes.Select(r => new RecipeDetailedItem
            {
                RecipeId = r.RecipeId,
                Title = r.Title,
                
                HowToPrepare = r.HowToPrepare,               
                Complexity = r.Complexity,
                Serves = r.Serves,
                ImageUrl = r.ImageUrl
            }
            ).ToList();
        }
        public void CreateNewRecipe()
        {
            Recipe newRecipe = new Recipe();  //TODO: add values?
            _context.Recipes.Add(newRecipe);
            _context.SaveChanges();
        }

        //TODO: Add DeleteRacipe()
    }
}
