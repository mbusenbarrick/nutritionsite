using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionSite.Models
{
    public class Ingredient
    {
        public int ID { set; get; }
        public int FoodID { set; get; }
        
        public int Amount { set; get; }
        public int DailyNutritionID { set; get; }

        public Food Food { get; set; }
        public DailyNutrition DailyNutrition { get; set; }
    }
}
