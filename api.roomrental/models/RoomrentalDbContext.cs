using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.models
{
    public class RoomRentalDBContext : DbContext
    {

        DbSet<Room> Rooms { get; set; }
        public RoomRentalDBContext(DbContextOptions<RoomRentalDBContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.
        //    base.OnConfiguring(optionsBuilder);
        //}
    }

}
