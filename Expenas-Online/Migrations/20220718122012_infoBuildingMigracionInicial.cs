using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expenas_Online.Migrations
{
    public partial class infoBuildingMigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Floor = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Floor);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Debt = table.Column<float>(type: "REAL", nullable: false),
                    BuildingFloor = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floor_Building_BuildingFloor",
                        column: x => x.BuildingFloor,
                        principalTable: "Building",
                        principalColumn: "Floor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Debt = table.Column<float>(type: "REAL", nullable: false),
                    BuildingFloor = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitDto_Building_BuildingFloor",
                        column: x => x.BuildingFloor,
                        principalTable: "Building",
                        principalColumn: "Floor");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floor_BuildingFloor",
                table: "Floor",
                column: "BuildingFloor");

            migrationBuilder.CreateIndex(
                name: "IX_UnitDto_BuildingFloor",
                table: "UnitDto",
                column: "BuildingFloor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "UnitDto");

            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}
