using RecipesWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesWebApp.Data.Services
{
	public interface IRecipesService
	{
		Task<IEnumerable<Recipe>> GetAll();
		Recipe GetById(int id);
		void Add(Recipe recipe);
		Recipe Update(int id, Recipe newRecipe);
		void Delete(int id);
	}
}
