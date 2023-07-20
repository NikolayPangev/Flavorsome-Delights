using Azure.Identity;
using FlavorsomeDelights.WebApp.Database;
using FlavorsomeDelights.WebApp.Models;
using FlavorsomeDelights.WebApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FlavorsomeDelights.WebApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly Contexts _context;
        public RecipeController(Contexts context)
        {
            _context = context;
        }
        // GET: Recipe
        public async Task<IActionResult> Index()
        {
            var repository = new RecipeRepository(_context);
            var result = repository.GetAllRecipes();

            return View(new Recipes { Items = result });
        }

        // GET: Recipe/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var repository = new RecipeRepository(_context);
            var result = repository.GetRecipeDetails(id);

            return View(result);
        }

        // GET: Recipe/Create
        public ActionResult Create()
        {
            var repository = new CategoryRepository(_context);
            var allCategories = repository.GetAllCategories();
            var result = allCategories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Type
            });
            ViewBag.Categories = result;
            ViewBag.ComplexityTypes = new List<SelectListItem>
            {
                new SelectListItem { Value = "Beginner", Text = "Beginner" },
                new SelectListItem { Value = "Intermediate", Text = "Intermediate" },
                new SelectListItem { Value = "Advanced", Text = "Advanced" }
            };

            return View(new RecipeCreateItem());
        }

        // POST: Recipe/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            var repository = new RecipeRepository(_context);
            var recipe = new RecipeCreateItem
            {
                Title = collection["Title"],
                HowToPrepare = collection["HowToPrepare"],
                Complexity = collection["Complexity"],
                Serves = int.Parse(collection["Serves"]),
                ImageUrl = collection["ImageUrl"],
                CategoryId = int.Parse(collection["CategoryId"]),
            };
            repository.CreateNewRecipe(recipe);

            return RedirectToAction(nameof(Index));
        }

        // GET: Recipe/Edit/5
        public async Task<IActionResult> Edit(int id)   //TODO: Check if it works correctly
        {
            var repository = new RecipeRepository(_context);    //TODO:neccessary? -> if(id!=0); if(result!=null)...

            if (id == 0)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]      //TODO: continue
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipe/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(r => r.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipe/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]  //TODO: check if it works
        public async Task<IActionResult> DeleteConfirmed(IFormCollection collection)
        {
            string idAsString = collection["recipe.id"];
            var repository = new RecipeRepository(_context);
            repository.DeleteRecipe(int.Parse(idAsString));

            return RedirectToAction(nameof(Index));
        }
    }
}
