﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NutritionSite.Models;

namespace NutritionSite.Migrations
{
    [DbContext(typeof(NutritionSiteContext))]
    [Migration("20170606225423_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
        }
    }
}
