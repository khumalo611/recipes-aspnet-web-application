using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Data;
using RecipesWebApp.Data.Services;
using RecipesWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly IIngredientsService _service;

        public IngredientsController(IIngredientsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allIngredients = await _service.GetAllAsync();
            return View(allIngredients);
        }

        //GET: Recipes/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return View(ingredient);
            }
            await _service.AddAsync(ingredient);
            return RedirectToAction(nameof(Index));
        }

        //GET: Recipes/Details
        public async Task<IActionResult> Details(int id)
        {
            var ingredientDetails = await _service.GetByIdAsync(id);
            if (ingredientDetails == null)
            {
                return View("NotFound");
            }
            return View(ingredientDetails);
        }

        //GET: Recipes/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var ingredientDetails = await _service.GetByIdAsync(id);
            if (ingredientDetails == null)
            {
                return View("NotFound");
            }
            return View(ingredientDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Ingredient ingredient)
        {
            ingredient.Id = id;
            if (!ModelState.IsValid)
            {
                return View(ingredient);
            }
            await _service.UpdateAsync(id, ingredient);
            return RedirectToAction(nameof(Index));
        }

        //GET: Recipes/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var ingredientDetails = await _service.GetByIdAsync(id);
            if (ingredientDetails == null)
            {
                return View("NotFound");
            }
            return View(ingredientDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingredientDetails = await _service.GetByIdAsync(id);
            if (ingredientDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
