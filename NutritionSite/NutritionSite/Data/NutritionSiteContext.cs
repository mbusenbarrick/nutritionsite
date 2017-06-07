using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NutritionSite.Models
{
    public class NutritionSiteContext : DbContext
    {
        public NutritionSiteContext (DbContextOptions<NutritionSiteContext> options)

            : base(options)
        {
        }

        public DbSet<NutritionSite.Models.Food> Food { get; set; }
        public DbSet<NutritionSite.Models.Ingredient> Ingredient { get; set; }
        public DbSet<NutritionSite.Models.DailyNutrition> DailyNutrition { get; set; }
    }
}
