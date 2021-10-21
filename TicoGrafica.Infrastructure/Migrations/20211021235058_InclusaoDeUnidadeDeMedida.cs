using Microsoft.EntityFrameworkCore.Migrations;

namespace TicoGrafica.Infrastructure.Migrations
{
    public partial class InclusaoDeUnidadeDeMedida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnidadeDeMedida",
                table: "Produto",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadeDeMedida",
                table: "Produto");
        }
    }
}
