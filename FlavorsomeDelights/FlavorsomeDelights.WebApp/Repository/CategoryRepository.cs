using FlavorsomeDelights.WebApp.Database;
using FlavorsomeDelights.WebApp.Entities;
using FlavorsomeDelights.WebApp.Models;

namespace FlavorsomeDelights.WebApp.Repository
{
    public class CategoryRepository
    {
        private readonly Contexts _context;

        public CategoryRepository(Contexts context)
        {
            _context = context;
        }

        public List<CategoryListItem> GetAllCategories()
        {
            return _context.Categories.Select(c => new CategoryListItem
            {
                Id = c.CategoryId,
                Type = c.Type
            }
            ).OrderBy(c => c.Type).ToList();
        }
    }
}
