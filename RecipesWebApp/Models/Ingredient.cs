using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RecipesWebApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Display(Name = "Ingredient Name")]
        public string Name { get; set; }

        //Relationships
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}
