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
    }

  

}
