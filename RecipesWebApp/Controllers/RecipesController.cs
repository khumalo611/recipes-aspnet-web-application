using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Data;
using RecipesWebApp.Data.Services;
using RecipesWebApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipesService _service;

        public RecipesController(IRecipesService service)
        {
			_service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allRecipes = await _service.GetAllAsync();
            return View(allRecipes);
        }

		public async Task<IActionResult> IndexB()
		{
			var allRecipes = await _service.GetAllAsync();
			return View(allRecipes);
		}

		//GET: Recipes/Create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Recipe recipe)
		{
			if (!ModelState.IsValid)
			{
				return View(recipe);
			}
			await _service.AddAsync(recipe);
			return RedirectToAction(nameof(Index));
		}

		//GET: Recipes/Details
		public async Task<IActionResult> Details(int id)
		{
			var recipeDetails = await _service.GetByIdAsync(id);
			if (recipeDetails == null)
			{
				return View("NotFound");
			}
			return View(recipeDetails);
		}

		//GET: Recipes/Edit
		public async Task<IActionResult> Edit(int id)
		{
			var recipeDetails = await _service.GetByIdAsync(id);
			if (recipeDetails == null)
			{
				return View("NotFound");
			}
			return View(recipeDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, Recipe recipe)
		{
			recipe.Id = id;
			if (!ModelState.IsValid)
			{
				return View(recipe);
			}
			await _service.UpdateAsync(id, recipe);
			return RedirectToAction(nameof(Index));
		}

		//GET: Recipes/Delete
		public async Task<IActionResult> Delete(int id)
		{
			var recipeDetails = await _service.GetByIdAsync(id);
			if (recipeDetails == null)
			{
				return View("NotFound");
			}
			return View(recipeDetails);
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var recipeDetails = await _service.GetByIdAsync(id);
			if (recipeDetails == null)
			{
				return View("NotFound");
			}

			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
