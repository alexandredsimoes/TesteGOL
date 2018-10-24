using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteGOL.Infrastructing.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplane",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CodigoAviao = table.Column<string>(maxLength: 10, nullable: false),
                    Modelo = table.Column<string>(maxLength: 100, nullable: false),
                    Passageiros = table.Column<int>(nullable: false),
                    DataRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplane", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplane");
        }
    }
}
