using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly AppDbContext _context;

        public IngredientsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allIngredients = await _context.Ingredients.OrderBy(n => n.Name).ToListAsync();
            return View(allIngredients);
        }
    }
}
