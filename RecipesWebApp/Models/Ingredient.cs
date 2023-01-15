using System.Collections.Generic;

namespace RecipesWebApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationships
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}
