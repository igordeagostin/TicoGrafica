using Microsoft.EntityFrameworkCore.Migrations;

namespace TicoGrafica.Infrastructure.Migrations
{
    public partial class RenomearColunaDataDeEntrega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDeEntrega",
                table: "ContasReceber",
                newName: "DataDoPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDoPedido",
                table: "ContasReceber",
                newName: "DataDeEntrega");
        }
    }
}
