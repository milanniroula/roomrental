using api.roomrental.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.models
{
    public class RoomrentalDbContext : IdentityDbContext
    {

        public RoomrentalDbContext(DbContextOptions<RoomrentalDbContext> options) : base(options) { }

        public DbSet<AppUser> ApplicationUsers { get; set; }


        public DbSet<AdType> AdTypes { get; set; }
        public DbSet<AdCategory> AdCategories { get; set; }
        public DbSet<AdPost> AdPost { get; set; }
        public DbSet<CategoryAttribute> CategoryAttributes { get; set; }
        public DbSet<AttributeValueType> AttributeValueTypes { get; set; }
        public DbSet<AttributeValueDataType> AttributeValueDataTypes { get; set; }
        public DbSet<AttributeValueOption> AttributeValueOptions { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            // AdCategory
            builder.Entity<AdCategory>(entity =>
            {
                entity.HasKey(a => a.CategoryId);
                entity.Property(a => a.CategoryId).ValueGeneratedNever();
                entity.Property(a => a.CategoryId).IsRequired();
                entity.HasIndex(e => e.CategoryId).IsUnique();
                entity.HasIndex(e => e.CategoryName).IsUnique();

            });


            // AdType
            builder.Entity<AdType>(entity =>
            {
                entity.HasKey(a => a.AdTypeId);
                entity.Property(a => a.AdTypeId).ValueGeneratedNever();
                entity.HasIndex(e => e.AdTypeId).IsUnique();
                entity.Property(a => a.TypeName).IsRequired();
                entity.HasIndex(e => e.TypeName).IsUnique();


            });

            // AttributeValueDataType
            builder.Entity<AttributeValueDataType>(entity =>
            {
                entity.HasKey(a => a.ValueDataTypeId);
                entity.Property(a => a.ValueDataTypeId).ValueGeneratedNever();
                entity.HasIndex(e => e.ValueDataTypeId).IsUnique();
                entity.Property(a => a.ValueDataTypeName).IsRequired();
                entity.HasIndex(e => e.ValueDataTypeName).IsUnique();

            });

            // AttributeValueType
            builder.Entity<AttributeValueType>(entity =>
            {
                entity.HasKey(a => a.ValueTypeId);
                entity.Property(a => a.ValueTypeId).ValueGeneratedNever();
                entity.HasIndex(e => e.ValueTypeId).IsUnique();
                entity.Property(a => a.ValueTypeName).IsRequired();
                entity.HasIndex(e => e.ValueTypeName).IsUnique();

            });


            builder.Entity<AttributeValueOption>(entity =>
            {

                entity.Property(a => a.AttributeValueOptionId).ValueGeneratedNever();

            });



            builder.Entity<CategoryAttribute>(entity =>
            {
                entity.Property(a => a.CategoryAttributeId).ValueGeneratedNever();
                entity.HasOne(a => a.AttributeValueType);
                //entity.HasOne(b => b.Options);
                //entity.Property(a => a.OptionsId).IsRequired(false);
            });
            builder.Entity<AdPost>(entity =>
            {
                entity.HasOne(a => a.Category);
                entity.HasOne(b => b.AdType);
                entity.HasOne(c => c.Owner);
            });


        }
    }

}
