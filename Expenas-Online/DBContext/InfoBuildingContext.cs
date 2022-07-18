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
            var building = new Building[3]
            {
     
                        new Building()
                        {
                            Units = 3,
                        },
                        new Building()
                        {
                            Floor = 1,
                            Units = 4,
                        },new Building()
                        {
                            Floor = 1,
                            Units = 5,
                        },
            };
        }
      

}
