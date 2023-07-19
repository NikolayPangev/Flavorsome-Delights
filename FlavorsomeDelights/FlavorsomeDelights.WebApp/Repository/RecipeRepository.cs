using FlavorsomeDelights.WebApp.Database;
using FlavorsomeDelights.WebApp.Entities;
using FlavorsomeDelights.WebApp.Models;

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
        public RecipeDetailedItem GetRecipeDetails(int id)
        {
            return _context.Recipes.Where(x => x.RecipeId == id).Select(r => new RecipeDetailedItem
            {
                RecipeId = r.RecipeId,
                Title = r.Title,
                Ingredients = r.Ingredients.Select(i => new IngredientItem
                {
                    Id = i.IngredientId,
                    Name = i.Ingredient.Name,
                    Quantity = i.Quantity,
                }).ToList(),
                HowToPrepare = r.HowToPrepare,
                Complexity = r.Complexity,
                Serves = r.Serves,
                ImageUrl = r.ImageUrl
            }).Single();
        }
        public void CreateNewRecipe()
        {
            Recipe newRecipe = new Recipe();  //TODO: add values?
            _context.Recipes.Add(newRecipe);
            _context.SaveChanges();
        }

        public async void DeleteRecipe(int id)
        {
            var recipeForDelete = await _context.Recipes.FindAsync(id);
            if(recipeForDelete != null)
            {
                _context.Recipes.Remove(recipeForDelete);
                await _context.SaveChangesAsync();
            }
        }

        public void EditRecipe(int id)
        {
            var recipeForDelete = _context.Recipes.Find(id);
            if (recipeForDelete != null)
            {
                _context.Recipes.Remove(recipeForDelete);
                _context.SaveChanges();
            }
        }
    }
}
