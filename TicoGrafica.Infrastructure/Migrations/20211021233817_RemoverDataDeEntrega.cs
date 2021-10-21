using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicoGrafica.Infrastructure.Migrations
{
    public partial class RemoverDataDeEntrega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDeEntrega",
                table: "ContasPagar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeEntrega",
                table: "ContasPagar",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
