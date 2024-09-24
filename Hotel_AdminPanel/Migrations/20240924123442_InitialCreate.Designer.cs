﻿// <auto-generated />
using System;
using Hotel_AdminPanel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_AdminPanel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240924123442_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel_AdminPanel.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.MealPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Plan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MealPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Plan = "No Meal"
                        },
                        new
                        {
                            Id = 2,
                            Plan = "Breakfast"
                        },
                        new
                        {
                            Id = 3,
                            Plan = "Half Board"
                        },
                        new
                        {
                            Id = 4,
                            Plan = "Full Board"
                        });
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Adults")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("MealPlanId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationStatusId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("SpecialRequest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MealPlanId");

                    b.HasIndex("ReservationStatusId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.ReservationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReservationStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RStatus = "Reserved"
                        },
                        new
                        {
                            Id = 2,
                            RStatus = "CheckedIn"
                        },
                        new
                        {
                            Id = 3,
                            RStatus = "Completed"
                        },
                        new
                        {
                            Id = 4,
                            RStatus = "Canceled"
                        });
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxAdults")
                        .HasColumnType("int");

                    b.Property<int>("MaxChildren")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomStatusId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomStatusId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Image = "",
                            MaxAdults = 0,
                            MaxChildren = 0,
                            Price = 100m,
                            RoomNumber = "A101",
                            RoomStatusId = 1,
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Image = "",
                            MaxAdults = 0,
                            MaxChildren = 0,
                            Price = 150m,
                            RoomNumber = "A102",
                            RoomStatusId = 1,
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Image = "",
                            MaxAdults = 0,
                            MaxChildren = 0,
                            Price = 200m,
                            RoomNumber = "A103",
                            RoomStatusId = 1,
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Image = "",
                            MaxAdults = 0,
                            MaxChildren = 0,
                            Price = 250m,
                            RoomNumber = "A104",
                            RoomStatusId = 1,
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Image = "",
                            MaxAdults = 0,
                            MaxChildren = 0,
                            Price = 300m,
                            RoomNumber = "A105",
                            RoomStatusId = 1,
                            RoomTypeId = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Image = "",
                            MaxAdults = 0,
                            MaxChildren = 0,
                            Price = 350m,
                            RoomNumber = "A106",
                            RoomStatusId = 1,
                            RoomTypeId = 6
                        });
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.RoomStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Available"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Occupied"
                        });
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Single"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Double"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Studio"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Suite"
                        },
                        new
                        {
                            Id = 5,
                            Type = "MiniSuite"
                        },
                        new
                        {
                            Id = 6,
                            Type = "Presidential"
                        });
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.Reservation", b =>
                {
                    b.HasOne("Hotel_AdminPanel.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_AdminPanel.Models.MealPlan", "MealPlan")
                        .WithMany()
                        .HasForeignKey("MealPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_AdminPanel.Models.ReservationStatus", "ReservationStatus")
                        .WithMany()
                        .HasForeignKey("ReservationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_AdminPanel.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("MealPlan");

                    b.Navigation("ReservationStatus");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel_AdminPanel.Models.Room", b =>
                {
                    b.HasOne("Hotel_AdminPanel.Models.RoomStatus", "RoomStatus")
                        .WithMany()
                        .HasForeignKey("RoomStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_AdminPanel.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomStatus");

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
