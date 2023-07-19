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

            /*return _context.Movie != null ?
                        View(await _context.Movie.ToListAsync()) :
                        Problem("Entity set 'MvcMovieContext.Movie'  is null.");
        }
            /*public ActionResult Index()
        {
            /* ---
            List<RecipeListItem> result = new List<RecipeListItem>(); //TODO: RETRIEVE FROM DATABASE
            Recipes recipes = new Recipes { Items = result };
            return View(recipes);
            */
            /*List<RecipeListItem> recipes = _recipeRepository.GetAllRecipes();
            return View(recipes);*/
        }

        // GET: Recipe/Details/5
        public async Task<IActionResult> Details()
        {
            var repository = new RecipeRepository(_context);
            var result = repository.GetRecipeDetails();

            return View(new Recipes { RecipeDetailedItems = result });
            /*if (id == null)
            {
                return NotFound();
            }

            var recipes = await _context.Recipes
                .FirstOrDefaultAsync(r => r.RecipeId == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);*/
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipe/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
