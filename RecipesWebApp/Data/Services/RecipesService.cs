using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Data.Services
{
	public class RecipesService : IRecipesService
	{
		private readonly AppDbContext _context;
		public RecipesService(AppDbContext context)
		{
			_context = context;
		}

		public async Task AddAsync(Recipe recipe)
		{
			await _context.Recipes.AddAsync(recipe);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var result = await _context.Recipes.FirstOrDefaultAsync(n => n.Id == id);
			_context.Recipes.Remove(result);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Recipe>> GetAllAsync()
		{
			var result = await _context.Recipes.OrderByDescending(n => n.Id).ToListAsync();
			return result;
		}

		public async Task<Recipe> GetByIdAsync(int id)
		{
			var result = await _context.Recipes.FirstOrDefaultAsync(n => n.Id == id);
			return result;
		}

		public async Task<Recipe> UpdateAsync(int id, Recipe newRecipe)
		{
			_context.Update(newRecipe);
			await _context.SaveChangesAsync();
			return newRecipe;
		}
	}
}
