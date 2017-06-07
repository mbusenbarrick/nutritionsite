using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionSite.Models
{
    public class DailyNutrition
    {
        public int ID { get; set; }
        public DateTime Date { set; get; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
