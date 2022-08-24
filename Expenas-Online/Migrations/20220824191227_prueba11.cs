using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expenas_Online.Migrations
{
    public partial class prueba11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Deuda = table.Column<float>(type: "REAL", maxLength: 250, nullable: true),
                    PisoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unidades_Pisos_PisoId",
                        column: x => x.PisoId,
                        principalTable: "Pisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pisos",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Pisos",
                column: "Id",
                value: 2);

            migrationBuilder.InsertData(
                table: "Pisos",
                column: "Id",
                value: 3);

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "Id", "Deuda", "Nombre", "PisoId" },
                values: new object[] { 1, 5500f, "Sauan Matias", 1 });

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "Id", "Deuda", "Nombre", "PisoId" },
                values: new object[] { 2, 55650f, "Pecorelli Luca", 1 });

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "Id", "Deuda", "Nombre", "PisoId" },
                values: new object[] { 3, 55045540f, "Lucarini Gabriel", 2 });

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "Id", "Deuda", "Nombre", "PisoId" },
                values: new object[] { 4, 55300f, "Sanchez Claudia", 2 });

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "Id", "Deuda", "Nombre", "PisoId" },
                values: new object[] { 5, 5500f, "Bolaños Roberto", 3 });

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "Id", "Deuda", "Nombre", "PisoId" },
                values: new object[] { 6, 553400f, "Urushima Gabriel", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Unidades_PisoId",
                table: "Unidades",
                column: "PisoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Pisos");
        }
    }
}
