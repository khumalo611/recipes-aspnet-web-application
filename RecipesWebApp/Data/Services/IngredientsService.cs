using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Data.Services
{
    public class IngredientsService 
    {
        private readonly AppDbContext _context;
        public IngredientsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Ingredient ingredient)
        {
            await _context.Ingredients.AddAsync(ingredient);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Ingredients.FirstOrDefaultAsync(n => n.Id == id);
            _context.Ingredients.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            var result = await _context.Ingredients.OrderByDescending(n => n.Id).ToListAsync();
            return result;
        }

        public async Task<Ingredient> GetByIdAsync(int id)
        {
            var result = await _context.Ingredients.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Ingredient> UpdateAsync(int id, Ingredient newIngredient)
        {
            _context.Update(newIngredient);
            await _context.SaveChangesAsync();
            return newIngredient;
        }
    }
}
