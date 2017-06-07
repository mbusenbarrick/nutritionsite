using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutritionSite.Models
{
    public class DailyNutrition
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
