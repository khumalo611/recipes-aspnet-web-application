using RecipesWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesWebApp.Data.Services
{
    public interface IIngredientsService
    {
        Task<IEnumerable<Ingredient>> GetAllAsync();
        Task<Ingredient> GetByIdAsync(int id);
        Task AddAsync(Ingredient recipe);
        Task<Ingredient> UpdateAsync(int id, Ingredient newIngredient);
        Task DeleteAsync(int id);
    }
}
