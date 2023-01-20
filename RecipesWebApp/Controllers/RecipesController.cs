using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Controllers
{
    public class RecipesController : Controller
    {
        private readonly AppDbContext _context;

        public RecipesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allRecipes = await _context.Recipes.OrderByDescending(n => n.Id).ToListAsync();
            return View(allRecipes);
        }

		public async Task<IActionResult> IndexB()
		{
			var allRecipes = await _context.Recipes.OrderByDescending(n => n.Id).ToListAsync();
			return View(allRecipes);
		}
	}
}
