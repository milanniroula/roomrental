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
        public DbSet<AttributeType> AttributeTypes { get; set; }
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
                entity.HasIndex(e => e.AdCategoryName).IsUnique();

            });


            builder.Entity<AdType>(entity =>
            {
                entity.HasKey(a => a.AdTypeId);
                entity.Property(a => a.AdTypeId).ValueGeneratedNever();
                entity.HasIndex(e => e.AdTypeId).IsUnique();
                entity.Property(a => a.AdTypeName).IsRequired();
                entity.HasIndex(e => e.AdTypeName).IsUnique();


            });

            builder.Entity<AttributeType>(entity =>
            {

                entity.Property(a => a.AttributeTypeId).ValueGeneratedNever();

            });


            builder.Entity<AttributeValueOption>(entity =>
            {

                entity.Property(a => a.AttributeValueOptionId).ValueGeneratedNever();

            });



            builder.Entity<CategoryAttribute>(entity =>
            {
                entity.Property(a => a.CategoryAttributeId).ValueGeneratedNever();
                entity.HasOne(a => a.AttributeType);
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
