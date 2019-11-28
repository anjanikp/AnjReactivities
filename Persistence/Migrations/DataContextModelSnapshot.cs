﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Value101"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Value102"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Value103"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Value104"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Value105"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Value106"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Value107"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
