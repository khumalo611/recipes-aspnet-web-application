using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Models;

namespace RecipesWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe_Ingredient>().HasKey(ri => new
            {
                ri.RecipeId,
                ri.IngredientId
            });

            modelBuilder.Entity<Recipe_Ingredient>().HasOne(r => r.Recipe).WithMany(ri => ri.Recipes_Ingredients).HasForeignKey(r => r.RecipeId);
            modelBuilder.Entity<Recipe_Ingredient>().HasOne(r => r.Ingredient).WithMany(ri => ri.Recipes_Ingredients).HasForeignKey(r => r.IngredientId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}
