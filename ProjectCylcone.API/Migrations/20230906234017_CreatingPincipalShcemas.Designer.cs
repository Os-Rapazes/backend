﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectCylcone.API.Context;

#nullable disable

namespace ProjectCylcone.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230906234017_CreatingPincipalShcemas")]
    partial class CreatingPincipalShcemas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectCylcone.API.Models.Entities.Car", b =>
                {
                    b.Property<Guid>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("car_id");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext")
                        .HasColumnName("brand");

                    b.Property<int>("ColorId")
                        .HasColumnType("int")
                        .HasColumnName("color_id");

                    b.Property<string>("Model")
                        .HasColumnType("longtext")
                        .HasColumnName("model");

                    b.Property<string>("Plate")
                        .HasColumnType("longtext")
                        .HasColumnName("plate");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.HasKey("CarId");

                    b.HasIndex("ColorId");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("ProjectCylcone.API.Models.Entities.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("color_id");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("ColorId");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("ProjectCylcone.API.Models.Entities.Car", b =>
                {
                    b.HasOne("ProjectCylcone.API.Models.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");
                });
#pragma warning restore 612, 618
        }
    }
}