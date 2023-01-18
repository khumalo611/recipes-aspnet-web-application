using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RecipesWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RecipesWebApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) { 
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Ingredients
                if(!context.Ingredients.Any())
                {
                    context.Ingredients.AddRange(new List<Ingredient>()
                    {
                        new Ingredient ()
                        {
                            Name = "Breadcrumbs"
                        },

                        new Ingredient ()
                        {
                            Name = "Thyme"
                        },

                        new Ingredient ()
                        {
                            Name = "Lemon Zest"
                        },

                        new Ingredient ()
                        {
                            Name = "Butter"
                        },

                        new Ingredient ()
                        {
                            Name = "Kosher salt"
                        },

                        new Ingredient ()
                        {
                            Name = "Full Chicken" //6
                        },

                        new Ingredient ()
                        {
                            Name = "Fettuccini"
                        },

                        new Ingredient ()
                        {
                            Name = "Parmesan"
                        },

                        new Ingredient ()
                        {
                            Name = "Freshly ground black pepper"
                        },

                        new Ingredient ()
                        {
                            Name = "Rib-eye steak"
                        },

                        new Ingredient ()
                        {
                            Name = "Freshly ground pepper"
                        },

                        new Ingredient ()
                        {
                            Name = "Vegetable oil" //12
                        },

                        new Ingredient ()
                        {
                            Name = "Rosemary"
                        },

                        new Ingredient ()
                        {
                            Name = "Garlic cloves"
                        },

                        new Ingredient ()
                        {
                            Name = "Sea salt"
                        },

                        new Ingredient ()
                        {
                            Name = "White sandwich bread"
                        },

                        new Ingredient ()
                        {
                            Name = "Gochujang (Korean hot pepper paste)"
                        },

                        new Ingredient ()
                        {
                            Name = "Cheddar" //18
                        },

                        new Ingredient ()
                        {
                            Name = "Kimchi"
                        },

                        new Ingredient ()
                        {
                            Name = "Cherries"
                        },

                        new Ingredient ()
                        {
                            Name = "Red currants"
                        },

                        new Ingredient ()
                        {
                            Name = "Sugar"
                        },

                        new Ingredient ()
                        {
                            Name = "Plain whole-milk Greek yogurt"
                        },

                        new Ingredient ()
                        {
                            Name = "Wildflower" //24
                        },

                        new Ingredient ()
                        {
                            Name = "Non-fat yogurt"
                        },

                        new Ingredient ()
                        {
                            Name = "Non-fat milk"
                        },

                        new Ingredient ()
                        {
                            Name = "Medjool dates"
                        },

                        new Ingredient ()
                        {
                            Name = "Vanilla extract"
                        },

                        new Ingredient ()
                        {
                            Name = "Ice cubes"
                        }
                    });
                    context.SaveChanges();
                }

                //Recipes
                if (!context.Recipes.Any())
                {
                    context.Recipes.AddRange(new List<Recipe>()
                    {
                        new Recipe ()
                        {
                            ImageURL = "~/images/buttery-roast-chicken.webp",
                            Name = "Buttery Roasted Chicken",
                            DateAdded = DateTime.Now,
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/fettuccine-alfredo.webp",
                            Name = "Fetticcine Alfredo",
                            DateAdded = DateTime.Now.AddDays(-1),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/butter-basted-steak.webp",
                            Name = "Butter Basted Steak",
                            DateAdded = DateTime.Now.AddDays(-2),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/Inside Out Kimchi Grilled Cheese.webp",
                            Name = "Kimchi Grilled Cheese",
                            DateAdded = DateTime.Now.AddDays(-3),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/cherry-compote-with-honey-yogurt.webp",
                            Name = "Cherry Compote with Honey Yogurt",
                            DateAdded = DateTime.Now.AddDays(-4),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/cherry-compote-with-honey-yogurt.webp",
                            Name = "Cherry Compote with Honey Yoghurt",
                            DateAdded = DateTime.Now.AddDays(-4),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/cherry-compote-with-honey-yogurt.webp",
                            Name = "Cherry Compote with Honey Yogurt",
                            DateAdded = DateTime.Now.AddDays(-4),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        },

                        new Recipe ()
                        {
                            ImageURL = "~/images/vanilla-date-smoothie-crop.webp",
                            Name = "Vanilla Date Smoothie Crop",
                            DateAdded = DateTime.Now.AddDays(-5),
                            Author = "user@restaurant.co.za",
                            Instructions = "[Instruction Placeholder]"
                        }
                    });
                    context.SaveChanges();
                }
                //Recipes & Ingredients
                if (!context.Recipes_Ingredients.Any())
                {
                    context.Recipes_Ingredients.AddRange(new List<Recipe_Ingredient>()
                    {
                        new Recipe_Ingredient ()
                        {
                            RecipeId = 1,
                            IngredientId = 1
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 1,
                            IngredientId = 2
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 1,
                            IngredientId = 3
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 1,
                            IngredientId = 4
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 1,
                            IngredientId = 5
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 1,
                            IngredientId = 6
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 2,
                            IngredientId = 7
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 2,
                            IngredientId = 5
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 2,
                            IngredientId = 4
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 2,
                            IngredientId = 8
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 2,
                            IngredientId = 9
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 10
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 5
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 11
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 12
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 4
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 13
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 14
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 3,
                            IngredientId = 15
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 4,
                            IngredientId = 16
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 4,
                            IngredientId = 4
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 4,
                            IngredientId = 17
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 4,
                            IngredientId = 18
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 4,
                            IngredientId = 19
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 5,
                            IngredientId = 20
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 5,
                            IngredientId = 21
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 5,
                            IngredientId = 22
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 5,
                            IngredientId = 23
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 5,
                            IngredientId = 24
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 5,
                            IngredientId = 5
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 6,
                            IngredientId = 25
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 6,
                            IngredientId = 26
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 6,
                            IngredientId = 27
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 6,
                            IngredientId = 28
                        },

                        new Recipe_Ingredient ()
                        {
                            RecipeId = 6,
                            IngredientId = 29
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
