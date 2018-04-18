using api.roomrental.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.models
{
    public class RoomrentalDbContext : IdentityDbContext
    {

        public RoomrentalDbContext(DbContextOptions<RoomrentalDbContext> options) : base(options) { }

        public DbSet<AppUser> ApplicationUsers { get; set; }



    }

}
