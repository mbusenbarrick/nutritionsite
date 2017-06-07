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
    }
}
