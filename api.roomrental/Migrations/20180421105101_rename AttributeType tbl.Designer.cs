﻿// <auto-generated />
using api.roomrental.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace api.roomrental.Migrations
{
    [DbContext(typeof(RoomrentalDbContext))]
    [Migration("20180421105101_rename AttributeType tbl")]
    partial class renameAttributeTypetbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.roomrental.Entities.AdCategory", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName");

                    b.Property<string>("NormalisedCategoryName");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("CategoryName")
                        .IsUnique()
                        .HasFilter("[CategoryName] IS NOT NULL");

                    b.ToTable("AdCategories");
                });

            modelBuilder.Entity("api.roomrental.Entities.AdPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdTypeId");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("ExpireAt");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("OwnerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AdTypeId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("AdPost");
                });

            modelBuilder.Entity("api.roomrental.Entities.AdType", b =>
                {
                    b.Property<int>("AdTypeId");

                    b.Property<string>("NormalisedTypeName");

                    b.Property<string>("TypeName")
                        .IsRequired();

                    b.HasKey("AdTypeId");

                    b.HasIndex("AdTypeId")
                        .IsUnique();

                    b.HasIndex("TypeName")
                        .IsUnique();

                    b.ToTable("AdTypes");
                });

            modelBuilder.Entity("api.roomrental.Entities.AttributeValueOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeValueOptionId");

                    b.Property<int>("CategoryAttributeId");

                    b.Property<string>("Label");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CategoryAttributeId");

                    b.ToTable("AttributeValueOptions");
                });

            modelBuilder.Entity("api.roomrental.Entities.AttributeValueType", b =>
                {
                    b.Property<int>("TypeId");

                    b.Property<string>("TypeName")
                        .IsRequired();

                    b.HasKey("TypeId");

                    b.HasIndex("TypeId")
                        .IsUnique();

                    b.HasIndex("TypeName")
                        .IsUnique();

                    b.ToTable("AttributeValueTypes");
                });

            modelBuilder.Entity("api.roomrental.Entities.CategoryAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttributeLabel");

                    b.Property<int?>("AttributeTypeTypeId");

                    b.Property<int>("AttrubuteTypeId");

                    b.Property<int>("CategoryAttributeId");

                    b.Property<int>("CategoryId");

                    b.HasKey("Id");

                    b.HasIndex("AttributeTypeTypeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryAttributes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("api.roomrental.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.ToTable("AppUser");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("api.roomrental.Entities.AdPost", b =>
                {
                    b.HasOne("api.roomrental.Entities.AdType", "AdType")
                        .WithMany()
                        .HasForeignKey("AdTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("api.roomrental.Entities.AdCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("api.roomrental.Entities.AppUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("api.roomrental.Entities.AttributeValueOption", b =>
                {
                    b.HasOne("api.roomrental.Entities.CategoryAttribute")
                        .WithMany("Options")
                        .HasForeignKey("CategoryAttributeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("api.roomrental.Entities.CategoryAttribute", b =>
                {
                    b.HasOne("api.roomrental.Entities.AttributeValueType", "AttributeType")
                        .WithMany()
                        .HasForeignKey("AttributeTypeTypeId");

                    b.HasOne("api.roomrental.Entities.AdCategory")
                        .WithMany("CategoryAttributes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
