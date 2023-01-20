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
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        [Display(Name = "Recipe Name")]
        public string Name { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Author")]
        public string Author { get; set; }
        [Display(Name = "Instructions")]
        public string Instructions { get; set; }

        //Relationships
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}
