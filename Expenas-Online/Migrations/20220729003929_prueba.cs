using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expenas_Online.Migrations
{
    public partial class prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Debt = table.Column<float>(type: "REAL", nullable: false),
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floor_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "asd" });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "sss" });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "eeeeo" });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "Debt", "Nombre" },
                values: new object[] { 1, 1, 3000f, "Carla" });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "Debt", "Nombre" },
                values: new object[] { 2, 1, 9000f, "Roberto" });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "Debt", "Nombre" },
                values: new object[] { 3, 1, 8000f, "Juan" });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "Debt", "Nombre" },
                values: new object[] { 4, 1, 2000f, "s" });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "Debt", "Nombre" },
                values: new object[] { 5, 2, 1000f, "a" });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "Debt", "Nombre" },
                values: new object[] { 6, 2, 4000f, "aeae" });

            migrationBuilder.CreateIndex(
                name: "IX_Floor_BuildingId",
                table: "Floor",
                column: "BuildingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}
