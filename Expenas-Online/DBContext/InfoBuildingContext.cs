using Expenas_Online.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expenas_Online.DBContext
{
    public class InfoBuildingContext : DbContext
    {
        public DbSet<Building> Building { get; set; }
        public DbSet<Floor> Floor { get; set; }

        public InfoBuildingContext(DbContextOptions<InfoBuildingContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Floor> floor = new List<Floor>()
            {
            new Floor("asdasd") {
                Id=101,
                Debt=5000 },
            new Floor("asdas") {
                Id=102,
                Debt=6000 },
            };


            var building = new Building[3]
            {
                new Building("asd")
                {
                    Id = 1
                },
                new Building("sss")
                {
                    Id=2
                },
                new Building("eeeeo")
                {
                    Id=3
                }
            };
            modelBuilder.Entity<Building>().HasData(building);

            modelBuilder.Entity<Floor>().HasData(
                new Floor("Carla")
                {
                    Id = 1,
                    Debt = 3000,
                    BuildingId = 1
                },
                new Floor("Roberto")
                {
                    Id = 2,
                    Debt = 9000,
                    BuildingId = 1
                },

                new Floor("Juan")
                {
                    Id = 3,
                    Debt = 8000,
                    BuildingId = 1
                },
                new Floor("s")
                {
                    Id = 4,
                    Debt = 2000,
                    BuildingId = 1
                },
                new Floor("a")
                {
                    Id = 5,
                    Debt = 1000,
                    BuildingId = 2
                },
                new Floor("aeae")
                {
                    Id = 6,
                    Debt =  4000,
                    BuildingId = 2
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}