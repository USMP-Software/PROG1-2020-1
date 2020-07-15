using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSqlServer.Migrations
{
    public partial class FechaNacimientoEntrenadorTipoPokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Pokemones",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Entrenadores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Pokemones");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Entrenadores");
        }
    }
}
