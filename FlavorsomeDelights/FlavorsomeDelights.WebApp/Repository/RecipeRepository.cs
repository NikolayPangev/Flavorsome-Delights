using FlavorsomeDelights.WebApp.Database;
using FlavorsomeDelights.WebApp.Entities;
using FlavorsomeDelights.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Repository
{
    public class RecipeRepository
    {
        Random r = new Random();
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
            }).ToList();
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
        public void CreateNewRecipe(RecipeCreateItem recipe)
        {
            Recipe newRecipe = new Recipe
            {
                Title = recipe.Title,
                HowToPrepare = recipe.HowToPrepare,
                Complexity = recipe.Complexity,
                Serves = recipe.Serves,
                ImageUrl = recipe.ImageUrl,
                CategoryId = recipe.CategoryId,
                Ingredients = new List<RecipeIngredient>()
            };

            for (int i = 0; i < 5; i++)
            {
                int idOfIngredient = r.Next(1, 40);
                int quantity = r.Next(1, 10);
                var ingredient = _context.Ingredients.Single(i => i.IngredientId == idOfIngredient);

                newRecipe.Ingredients.Add(new RecipeIngredient
                {
                    Ingredient = ingredient,
                    Quantity = quantity,
                });
            }

            _context.Recipes.Add(newRecipe);
            _context.SaveChanges();
        }

        public void DeleteRecipe(int id)
        {
            var recipeForDelete = _context.Recipes.Find(id);
            if (recipeForDelete != null)
            {
                _context.Recipes.Remove(recipeForDelete);
                _context.SaveChanges();
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
