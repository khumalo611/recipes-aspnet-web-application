using RecipesWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesWebApp.Data.Services
{
	public interface IRecipesService
	{
		Task<IEnumerable<Recipe>> GetAllAsync();
		Task<Recipe> GetByIdAsync(int id);
		Task AddAsync(Recipe recipe);
		Task<Recipe> UpdateAsync(int id, Recipe newRecipe);
		Task DeleteAsync(int id);
	}
}
