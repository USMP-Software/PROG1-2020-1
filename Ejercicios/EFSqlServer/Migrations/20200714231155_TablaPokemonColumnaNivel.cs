using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSqlServer.Migrations
{
    public partial class TablaPokemonColumnaNivel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "Pokemones",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Pokemones");
        }
    }
}
