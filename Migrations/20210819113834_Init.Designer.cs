﻿// <auto-generated />
using System;
using Garage2._0G6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Garage2._0G6.Migrations
{
    [DbContext(typeof(Garage2_0G6Context))]
    [Migration("20210819113834_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage2._0G6.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Arrivaldate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regnum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Wheel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 405, DateTimeKind.Local).AddTicks(5251),
                            Brand = "Volvo",
                            Color = "red",
                            Model = "X3",
                            Regnum = "123ABC",
                            Type = 3,
                            Wheel = 4
                        },
                        new
                        {
                            Id = 2,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4314),
                            Brand = "Toyota",
                            Color = "red",
                            Model = "Corolla",
                            Regnum = "125ABC",
                            Type = 3,
                            Wheel = 4
                        },
                        new
                        {
                            Id = 3,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4358),
                            Brand = "Volvo",
                            Color = "blue",
                            Model = "XC60",
                            Regnum = "226ABC",
                            Type = 3,
                            Wheel = 4
                        },
                        new
                        {
                            Id = 4,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4364),
                            Brand = "Volvo",
                            Color = "black",
                            Model = "X3",
                            Regnum = "122ABC",
                            Type = 3,
                            Wheel = 4
                        },
                        new
                        {
                            Id = 5,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4369),
                            Brand = "Harley Davidson",
                            Color = "black",
                            Model = "Street 750",
                            Regnum = "225ABC",
                            Type = 4,
                            Wheel = 2
                        },
                        new
                        {
                            Id = 6,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4373),
                            Brand = "Yamaha",
                            Color = "red",
                            Model = "Bolt",
                            Regnum = "115ABC",
                            Type = 4,
                            Wheel = 2
                        },
                        new
                        {
                            Id = 7,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4377),
                            Brand = "Volvo",
                            Color = "white",
                            Model = "Epic V8",
                            Regnum = "112ABC",
                            Type = 1,
                            Wheel = 0
                        },
                        new
                        {
                            Id = 8,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4381),
                            Brand = "Toyota",
                            Color = "red",
                            Model = "Epic SX",
                            Regnum = "321ABC",
                            Type = 1,
                            Wheel = 0
                        },
                        new
                        {
                            Id = 9,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4385),
                            Brand = "Volvo",
                            Color = "blue",
                            Model = "X4",
                            Regnum = "322ABC",
                            Type = 2,
                            Wheel = 6
                        },
                        new
                        {
                            Id = 10,
                            Arrivaldate = new DateTime(2021, 8, 19, 13, 38, 34, 408, DateTimeKind.Local).AddTicks(4389),
                            Brand = "Yamaha",
                            Color = "white",
                            Model = "Revell",
                            Regnum = "331ABC",
                            Type = 0,
                            Wheel = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
