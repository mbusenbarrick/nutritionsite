using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionSite.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ServingSize { get; set; }
        public string ServingSizeType { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
    }
}
