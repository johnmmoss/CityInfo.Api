using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityInfo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.Data
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {
            // Force database
            //Database.EnsureCreated();

            //Database.Migrate();
        }

        public DbSet<Place> Places { get; set; }

        // One option for configuring - but can also pass to constructor!
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionString");

        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var city    = new PlaceType { Id = 1, Name = "City" };
            var town    = new PlaceType { Id = 2, Name = "Town" };
            var village = new PlaceType { Id = 3, Name = "Village" };

            modelBuilder.Entity<PlaceType>() .HasData( city, town, village );

            modelBuilder.Entity<Place>().HasData( 
               new Place { Id = 1, Name = "London", TypeId = city.Id},
               new Place { Id = 2, Name = "Aberdeen", TypeId = city.Id},
               new Place { Id = 3, Name = "Barnsley", TypeId = town.Id},
               new Place { Id = 4, Name = "Barking", TypeId = town.Id},
               new Place { Id = 5, Name = "Carlisle", TypeId = city.Id}
                );


        }
    }
}
