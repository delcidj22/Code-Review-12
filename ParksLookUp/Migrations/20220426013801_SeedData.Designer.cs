﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookUp.Models;

namespace ParksLookUp.Migrations
{
    [DbContext(typeof(ParkContext))]
    [Migration("20220426013801_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksLookUp.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Discovery Park",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Yosemite",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Grand Canyon National Park",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Olympic National Park",
                            State = "Washington"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Fort Stevens",
                            State = "Oregon"
                        },
                        new
                        {
                            ParkId = 6,
                            Name = "Letchworth State Park",
                            State = "New York"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
