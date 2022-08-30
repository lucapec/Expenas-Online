using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expenas_Online.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Password = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Rol = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "Rol", "UserName" },
                values: new object[] { 1, "mati123", 0, "matias" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "Rol", "UserName" },
                values: new object[] { 2, "luca123", 0, "luca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
