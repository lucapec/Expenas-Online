using Expenas_Online.Models;

namespace Expenas_Online.API.Controllers
{
    public class InquilinosData
    {
        public List<BuildingDto> Floors { get; set; }

        public static InquilinosData InstanciaActual { get; } = new InquilinosData();

    public InquilinosData()
        {
            Floors = new List<BuildingDto>()
            {
                new BuildingDto()
                {
                    Floor = 1, //piso de edificio
                    Units = new List<UnitDto>()
                    {
                        new UnitDto()
                        {
                            Id = 1,
                            Name = "Carla Rodriguez",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 2,
                            Name = "Roberto Rullo",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 3,
                            Name = "Mateo Fernandez",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 4,
                            Name = "Matias Volpe",
                            Debt = 5000
                        },
                    }

                },

                new BuildingDto()
                {
                    Floor = 2, //piso de edificio
                    Units = new List<UnitDto>()
                    {
                        new UnitDto()
                        {
                            Id = 1,
                            Name = "Matias Suasan",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 2,
                            Name = "Gabriel Lucapingui",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 3,
                            Name = "Mateo Abajo García", //Donw
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 4,
                            Name = "Gabriel Tocalino",
                            Debt = 5000
                        },
                    }

                },

                new BuildingDto()
                {
                    Floor = 3, //piso de edificio
                    Units = new List<UnitDto>()
                    {
                        new UnitDto()
                        {
                            Id = 1,
                            Name = "Juan Carlos SuckPik",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 2,
                            Name = "Luca Pitireli",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 3,
                            Name = "Juan Fernandez",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 4,
                            Name = "Pablo Bustos",
                            Debt = 5000
                        },
                    }

                },
                new BuildingDto()
                {
                    Floor = 4, //piso de edificio
                    Units = new List<UnitDto>()
                    {
                        new UnitDto()
                        {
                            Id = 1,
                            Name = "Carlos Messi",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 2,
                            Name = "Leonel Bianchi",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 3,
                            Name = "Martin Riquelme",
                            Debt = 5000
                        },
                        new UnitDto()
                        {
                            Id = 4,
                            Name = "Juan Román Palermo",
                            Debt = 5000
                        },
                    }

                },
            };
        }
    }
}
