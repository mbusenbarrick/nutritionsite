using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace NutritionSite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NutritionSiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<NutritionSiteContext>>()))
            {
                // Look for any movies.
                if (context.Food.Any())
                {
                    return;   // DB has been seeded
                }

                var foods = new Food[]
                    {
                     new Food
                     {
                         Name = "Eggs",
                         ServingSize = 1,
                         ServingSizeType = "item",
                         Calories = 70,
                         Protein = 6,
                         Fat = 5,
                         Carbs = 0
                     },

                     new Food
                     {
                         Name = "Special K Oats and Honey",
                         ServingSize = 100,
                         ServingSizeType = "g",
                         Calories = 100,
                         Protein = 0.5,
                         Fat = 5,
                         Carbs = 0
                     },
                     new Food
                     {
                         Name = "Peanut Butter",
                         ServingSize = 32,
                         ServingSizeType = "g",
                         Calories = 200,
                         Protein = 8,
                         Fat = 16,
                         Carbs = 6
                     },
                     new Food
                     {
                         Name = "Honey",
                         ServingSize = 21,
                         ServingSizeType = "g",
                         Calories = 60,
                         Protein = 0,
                         Fat = 0,
                         Carbs = 17
                     },
                     new Food
                     {
                         Name = "Whole milk",
                         ServingSize = 240,
                         ServingSizeType = "mL",
                         Calories = 150,
                         Protein = 8,
                         Fat = 8,
                         Carbs = 12
                     },
                     new Food
                     {
                         Name = "Protein Scoop",
                         ServingSize = 1,
                         ServingSizeType = "item",
                         Calories = 120,
                         Protein = 24,
                         Fat = 1,
                         Carbs = 3
                     },
                     new Food
                     {
                         Name = "Chicken",
                         ServingSize = 112,
                         ServingSizeType = "g",
                         Calories = 100,
                         Protein = 20,
                         Fat = 2.5,
                         Carbs = 12
                     },
                     new Food
                     {
                         Name = "Broccoli",
                         ServingSize = 85,
                         ServingSizeType = "g",
                         Calories = 30,
                         Protein = 1,
                         Fat = 0,
                         Carbs = 4
                     },
                     new Food
                     {
                         Name = "Mixed Nuts",
                         ServingSize = 28,
                         ServingSizeType = "g",
                         Calories = 170,
                         Protein = 6,
                         Fat = 15,
                         Carbs = 5
                     },
                     new Food
                     {
                         Name = "Bread",
                         ServingSize = 1,
                         ServingSizeType = "item",
                         Calories = 110,
                         Protein = 5,
                         Fat = 2,
                         Carbs = 20
                     }
                    };
                    foreach (Food f in foods)
                    {
                    context.Food.Add(f);
                    }
                context.SaveChanges();


                

                var dailies = new DailyNutrition[]
                {
                    new DailyNutrition
                    {
                        Name = "Monday"

                    }

                };

                foreach (DailyNutrition dn in dailies)
                {
                    context.DailyNutrition.Add(dn);
                }

                context.SaveChanges();

                var ingredients = new Ingredient[]
                {
                    new Ingredient
                    {
                        FoodID = foods.Single(f => f.Name == "Eggs").ID,
                        Amount = 4,
                        DailyNutritionID = dailies.Single(f => f.Name == "Monday").ID

                    },

                    new Ingredient
                    {
                        FoodID = foods.Single(f => f.Name == "Chicken").ID,
                        Amount = 400,
                        DailyNutritionID = dailies.Single(f => f.Name == "Monday").ID
                    },

                    new Ingredient
                    {
                        FoodID = foods.Single(f => f.Name == "Whole milk").ID,
                        Amount = 500,
                        DailyNutritionID = dailies.Single(f => f.Name == "Monday").ID
                    },

                    new Ingredient
                    {
                        FoodID = foods.Single(f => f.Name == "Protein Scoop").ID,
                        Amount = 2,
                        DailyNutritionID = dailies.Single(f => f.Name == "Monday").ID
                    }
                };

                foreach (Ingredient i in ingredients)
                {
                    context.Ingredient.Add(i);
                }
                context.SaveChanges();



            }
        }
    }
}