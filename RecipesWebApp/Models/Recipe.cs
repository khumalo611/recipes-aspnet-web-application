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
        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Recipe Name")]
		[Required(ErrorMessage = "Recipe Name is required")]
		public string Name { get; set; }
        [Display(Name = "Date Added")]
		[Required(ErrorMessage = "Date is required")]
		public DateTime DateAdded { get; set; }
        [Display(Name = "Author")]
        public string Author { get; set; }
        [Display(Name = "Instructions")]
		[Required(ErrorMessage = "Instructions are required")]
		public string Instructions { get; set; }

        //Relationships
        public List<Recipe_Ingredient> Recipes_Ingredients { get; set; }
    }
}
