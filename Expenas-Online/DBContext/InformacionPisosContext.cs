using ExpensasOnline.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensasOnline.API.DBContexts  
{
    public class InformacionPisosContext : DbContext
    {
        public DbSet<Piso> Pisos { get; set; } 
        public DbSet<Unidad> Unidades { get; set; }
        public InformacionPisosContext(DbContextOptions<InformacionPisosContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            var pisos = new Piso[3]
            {
                new Piso()
                {
                    Id = 1,
                   
                },
                new Piso()
                {
                    Id = 2,

                },
                new Piso()
                {
                    Id = 3,
                }
            };
            modelBuilder.Entity<Piso>().HasData(pisos);

            modelBuilder.Entity<Unidad>().HasData(
                new Unidad("Sauan Matias")
                {
                    Id = 1,
                    Deuda = 5500,
                    PisoId = pisos[0].Id
                },
                new Unidad("Pecorelli Luca")
                {
                    Id = 2,
                    Deuda = 55650,
                    PisoId = pisos[0].Id
                },

                new Unidad("Lucarini Gabriel")
                {
                    Id = 3,
                    Deuda = 55045540,
                    PisoId = pisos[1].Id
                },
                new Unidad("Sanchez Claudia")
                {
                    Id = 4,
                    Deuda = 55300,
                    PisoId = pisos[1].Id
                },
                new Unidad("Bolaños Roberto")
                {
                    Id = 5,
                    Deuda = 5500,
                    PisoId = pisos[2].Id
                },
                new Unidad("Urushima Gabriel")
                {
                    Id = 6,
                    Deuda = 553400,
                    PisoId = pisos[2].Id
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
