using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionSite.Models.ViewModels
{
    public class MealPlan
    {
        public IEnumerable<DailyNutrition> DailyNutrition { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Food> Foods { get; set; }
    }
}
