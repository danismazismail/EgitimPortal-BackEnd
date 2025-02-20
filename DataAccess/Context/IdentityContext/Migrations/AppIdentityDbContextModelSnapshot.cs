﻿// <auto-generated />
using System;
using DataAccess.Context.IdentityContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Context.IdentityContext.Migrations
{
    [DbContext(typeof(AppIdentityDbContext))]
    partial class AppIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.UserEntities.Concrete.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LoginCount")
                        .HasColumnType("integer");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("60bb4000-b9c3-4326-90ab-cb36ed4630b1"),
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "cb3efab5-0e26-4f93-9851-d56dc880e432",
                            CreatedDate = new DateTime(2024, 7, 12, 18, 10, 37, 700, DateTimeKind.Local).AddTicks(4389),
                            Email = "admin@bilgeadam.com",
                            EmailConfirmed = false,
                            FirstName = "Yönetici",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            LoginCount = 0,
                            NormalizedEmail = "ADMIN@BILGEADAM.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEEJqWAjY/nw736yMfMPoDkR/fDqL40Bec3QFIIXfEQF0a/p58ITFAfrbnCkq9YbdVw==",
                            PhoneNumberConfirmed = false,
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("d1fc3486-c6fd-47df-963a-bf7805b11216"),
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "7032109c-bed4-4b08-8394-b7c68cf3eb42",
                            CreatedDate = new DateTime(2024, 7, 12, 18, 10, 37, 812, DateTimeKind.Local).AddTicks(2632),
                            Email = "pelin.ozerserdar@bilgeadamakademi.com",
                            EmailConfirmed = false,
                            FirstName = "Pelin",
                            LastName = "Özer Serdar",
                            LockoutEnabled = false,
                            LoginCount = 0,
                            NormalizedEmail = "PELIN.OZERSERDAR@BILGEADAMAKADEMI.COM",
                            NormalizedUserName = "PELIN.OZERSERDAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEILu1tR6QTA/OCTGwxgVTp8l+R7zwWkSwC9xDUb89qe7SFVWzx2JQEPH88PMMTx1qQ==",
                            PhoneNumberConfirmed = false,
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "pelin.ozerserdar"
                        },
                        new
                        {
                            Id = new Guid("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1"),
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "8debb37a-e8db-4f8b-b698-ed8a71884823",
                            CreatedDate = new DateTime(2024, 7, 12, 18, 10, 37, 907, DateTimeKind.Local).AddTicks(1499),
                            Email = "sinaemre.bekar@bilgeadamakademi.com",
                            EmailConfirmed = false,
                            FirstName = "Sina Emre",
                            LastName = "Bekar",
                            LockoutEnabled = false,
                            LoginCount = 0,
                            NormalizedEmail = "SINAENMRE.BEKAR@BILGEADAMAKADEMI.COM",
                            NormalizedUserName = "SINAENMRE.BEKAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEEmuZvBfzNL83QsOo4pSpKSWwUDjUHVph5V68XG+rqPFTsaRg1rwY/EBG6jd7OgU3A==",
                            PhoneNumberConfirmed = false,
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "sinaemre.bekar"
                        },
                        new
                        {
                            Id = new Guid("676452dd-8a1c-4747-8252-9ba2642917ea"),
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1993, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "f07ca0fd-7f09-486e-970b-73a3451b7704",
                            CreatedDate = new DateTime(2024, 7, 12, 18, 10, 38, 6, DateTimeKind.Local).AddTicks(6335),
                            Email = "dicle.goya@bilgeadamakademi.com",
                            EmailConfirmed = false,
                            FirstName = "Dicle",
                            LastName = "Goya",
                            LockoutEnabled = false,
                            LoginCount = 0,
                            NormalizedEmail = "DICLE.GOYA@BILGEADAMAKADEMI.COM",
                            NormalizedUserName = "DICLE.GOYA",
                            PasswordHash = "AQAAAAIAAYagAAAAEK4u6pSA0EnLqsn/fchMN//P3DgmQy1EDiqhfd9FvXk3wAB5VzHp6RDbo1U6VqPBdg==",
                            PhoneNumberConfirmed = false,
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "dicle.goya"
                        },
                        new
                        {
                            Id = new Guid("f78a22b2-e756-485f-8729-88003bacf1ff"),
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "b16c3ca5-0bbc-4050-8786-b0455480f526",
                            CreatedDate = new DateTime(2024, 7, 12, 18, 10, 38, 105, DateTimeKind.Local).AddTicks(9107),
                            Email = "ismail.danismaz@bilgeadamakademi.com",
                            EmailConfirmed = false,
                            FirstName = "İsmail",
                            LastName = "Danışmaz",
                            LockoutEnabled = false,
                            LoginCount = 0,
                            NormalizedEmail = "ISMAIL.DANISMAZ@BILGEADAMAKADEMI.COM",
                            NormalizedUserName = "ISMAIL.DANISMAZ",
                            PasswordHash = "AQAAAAIAAYagAAAAEHs0SKvxOVP0wgLFobc6ZsFHGsV7zYzUvMkNg9SVH0hS7oMoRGaNeVIGTbbnIwAt+Q==",
                            PhoneNumberConfirmed = false,
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "ismail.danismaz"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("52ff41a6-5f72-4cef-9300-64c156772f2c"),
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("c846cec9-78f6-4ac8-b353-f30f856affc8"),
                            Name = "customarManager",
                            NormalizedName = "CUSTOMERMANAGER"
                        },
                        new
                        {
                            Id = new Guid("e9c75c3c-40fb-4c15-a960-504e1099ac2f"),
                            Name = "teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = new Guid("78521ce1-a9e3-47b9-9426-5ad7e669df26"),
                            Name = "student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("60bb4000-b9c3-4326-90ab-cb36ed4630b1"),
                            RoleId = new Guid("52ff41a6-5f72-4cef-9300-64c156772f2c")
                        },
                        new
                        {
                            UserId = new Guid("d1fc3486-c6fd-47df-963a-bf7805b11216"),
                            RoleId = new Guid("c846cec9-78f6-4ac8-b353-f30f856affc8")
                        },
                        new
                        {
                            UserId = new Guid("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1"),
                            RoleId = new Guid("e9c75c3c-40fb-4c15-a960-504e1099ac2f")
                        },
                        new
                        {
                            UserId = new Guid("676452dd-8a1c-4747-8252-9ba2642917ea"),
                            RoleId = new Guid("78521ce1-a9e3-47b9-9426-5ad7e669df26")
                        },
                        new
                        {
                            UserId = new Guid("f78a22b2-e756-485f-8729-88003bacf1ff"),
                            RoleId = new Guid("78521ce1-a9e3-47b9-9426-5ad7e669df26")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
