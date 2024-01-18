﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAcademyCarBook.DataAccessLayer.Concrete;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    [DbContext(typeof(CarBookContext))]
    [Migration("20231108131008_mig_howitwork")]
    partial class mig_howitwork
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Brand", b =>
                {
                    b.Property<int>("brandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("brandID"), 1L, 1);

                    b.Property<string>("brandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("brandStatus")
                        .HasColumnType("bit");

                    b.HasKey("brandID");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Car", b =>
                {
                    b.Property<int>("carID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carID"), 1L, 1);

                    b.Property<int>("KM")
                        .HasColumnType("int");

                    b.Property<int>("brandID")
                        .HasColumnType("int");

                    b.Property<int>("carStatusID")
                        .HasColumnType("int");

                    b.Property<int>("carcategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("cstatus")
                        .HasColumnType("bit");

                    b.Property<string>("gearType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("personCount")
                        .HasColumnType("tinyint");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("carID");

                    b.HasIndex("brandID");

                    b.HasIndex("carStatusID");

                    b.HasIndex("carcategoryID");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.CarCategory", b =>
                {
                    b.Property<int>("carcategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carcategoryID"), 1L, 1);

                    b.Property<string>("carcategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("cateStatus")
                        .HasColumnType("bit");

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("carcategoryID");

                    b.ToTable("carCategories");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.CarStatus", b =>
                {
                    b.Property<int>("carStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carStatusID"), 1L, 1);

                    b.Property<string>("carStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("carStatusID");

                    b.ToTable("carStatuses");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.HowItWork", b =>
                {
                    b.Property<int>("HowItWorkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HowItWorkID"), 1L, 1);

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HowItWorkID");

                    b.ToTable("howItWorks");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Location", b =>
                {
                    b.Property<int>("locationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("locationID"), 1L, 1);

                    b.Property<bool>("locStatus")
                        .HasColumnType("bit");

                    b.Property<string>("locationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("locationID");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Price", b =>
                {
                    b.Property<int>("priceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("priceID"), 1L, 1);

                    b.Property<int>("carID")
                        .HasColumnType("int");

                    b.Property<string>("priceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("priceValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("priceID");

                    b.HasIndex("carID");

                    b.ToTable("prices");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Service", b =>
                {
                    b.Property<int>("serviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("serviceID"), 1L, 1);

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("serviceID");

                    b.ToTable("services");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MyAcademyCarBook.DataAccessLayer.EntityFramework.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Car", b =>
                {
                    b.HasOne("MyAcademyCarBook.EntityLayer.Concrete.Brand", "brand")
                        .WithMany("cars")
                        .HasForeignKey("brandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyAcademyCarBook.EntityLayer.Concrete.CarStatus", "carStatus")
                        .WithMany("cars")
                        .HasForeignKey("carStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyAcademyCarBook.EntityLayer.Concrete.CarCategory", "carCategory")
                        .WithMany("cars")
                        .HasForeignKey("carcategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");

                    b.Navigation("carCategory");

                    b.Navigation("carStatus");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Price", b =>
                {
                    b.HasOne("MyAcademyCarBook.EntityLayer.Concrete.Car", "car")
                        .WithMany("prices")
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Brand", b =>
                {
                    b.Navigation("cars");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.Car", b =>
                {
                    b.Navigation("prices");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.CarCategory", b =>
                {
                    b.Navigation("cars");
                });

            modelBuilder.Entity("MyAcademyCarBook.EntityLayer.Concrete.CarStatus", b =>
                {
                    b.Navigation("cars");
                });
#pragma warning restore 612, 618
        }
    }
}
