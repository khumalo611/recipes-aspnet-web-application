using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesWebApp.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public string Author { get; set; }
        public string Instructions { get; set; }

        //Relationships
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }

        //Ingredient
        public int IngredientId { get; set; }
        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }
    }
}
