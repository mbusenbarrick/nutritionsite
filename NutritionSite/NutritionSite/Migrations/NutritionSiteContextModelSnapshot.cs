﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NutritionSite.Models;

namespace NutritionSite.Migrations
{
    [DbContext(typeof(NutritionSiteContext))]
    partial class NutritionSiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NutritionSite.Models.DailyNutrition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("DailyNutrition");
                });

            modelBuilder.Entity("NutritionSite.Models.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<double>("Carbs");

                    b.Property<double>("Fat");

                    b.Property<string>("Name");

                    b.Property<double>("Protein");

                    b.Property<int>("ServingSize");

                    b.Property<string>("ServingSizeType");

                    b.HasKey("ID");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("NutritionSite.Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("DailyNutritionID");

                    b.Property<int>("FoodID");

                    b.HasKey("ID");

                    b.HasIndex("DailyNutritionID");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("NutritionSite.Models.Ingredient", b =>
                {
                    b.HasOne("NutritionSite.Models.DailyNutrition")
                        .WithMany("Ingredients")
                        .HasForeignKey("DailyNutritionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
