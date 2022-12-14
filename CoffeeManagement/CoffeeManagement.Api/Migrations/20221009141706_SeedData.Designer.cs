// <auto-generated />
using System;
using CoffeeManagement.Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeManagement.Api.Migrations
{
    [DbContext(typeof(CoffeeManagementDbContext))]
    [Migration("20221009141706_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1001L, 1);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1001L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CheckIn")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TableFoodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("TableFoodId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.BillInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1001L, 1);

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("FoodId");

                    b.ToTable("BillInfos");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1001L, 1);

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoodCategoryId = 1,
                            Name = "Phin Sữa Đá",
                            Price = 29000m
                        },
                        new
                        {
                            Id = 2,
                            FoodCategoryId = 1,
                            Name = "Phin Đen Đá",
                            Price = 29000m
                        },
                        new
                        {
                            Id = 3,
                            FoodCategoryId = 2,
                            Name = "FREEZE Trà Xanh",
                            Price = 55000m
                        },
                        new
                        {
                            Id = 4,
                            FoodCategoryId = 2,
                            Name = "FREEZE Chocolate",
                            Price = 55000m
                        },
                        new
                        {
                            Id = 5,
                            FoodCategoryId = 3,
                            Name = "Trà Ổi Hồng",
                            Price = 45000m
                        },
                        new
                        {
                            Id = 6,
                            FoodCategoryId = 3,
                            Name = "Trà Đào",
                            Price = 45000m
                        },
                        new
                        {
                            Id = 7,
                            FoodCategoryId = 4,
                            Name = "Bánh Mì Gà",
                            Price = 29000m
                        },
                        new
                        {
                            Id = 8,
                            FoodCategoryId = 4,
                            Name = "Bánh Mì Pate",
                            Price = 29000m
                        });
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1001L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "FREEZE"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TEA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "BANH MI"
                        });
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.TableFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TableFoods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Table 01",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Table 02",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Table 03",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Table 04",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Table 05",
                            Status = 1
                        });
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Bill", b =>
                {
                    b.HasOne("CoffeeManagement.Api.DataModel.Account", "Account")
                        .WithMany("Bills")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoffeeManagement.Api.DataModel.TableFood", "TableFood")
                        .WithMany("Bills")
                        .HasForeignKey("TableFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("TableFood");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.BillInfo", b =>
                {
                    b.HasOne("CoffeeManagement.Api.DataModel.Bill", "Bill")
                        .WithMany("BillInfos")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoffeeManagement.Api.DataModel.Food", "Food")
                        .WithMany("BillInfos")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Food", b =>
                {
                    b.HasOne("CoffeeManagement.Api.DataModel.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Account", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Bill", b =>
                {
                    b.Navigation("BillInfos");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.Food", b =>
                {
                    b.Navigation("BillInfos");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("CoffeeManagement.Api.DataModel.TableFood", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
