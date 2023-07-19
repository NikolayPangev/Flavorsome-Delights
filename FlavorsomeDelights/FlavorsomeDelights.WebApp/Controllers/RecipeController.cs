using Azure.Identity;
using FlavorsomeDelights.WebApp.Database;
using FlavorsomeDelights.WebApp.Models;
using FlavorsomeDelights.WebApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return View(new RecipeDetailedItem());
        }

        // POST: Recipe/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var repository = new RecipeRepository(_context);
            repository.DeleteRecipe(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
