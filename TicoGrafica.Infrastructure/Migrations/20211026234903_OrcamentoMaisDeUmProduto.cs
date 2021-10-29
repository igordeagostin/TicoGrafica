using Microsoft.EntityFrameworkCore.Migrations;

namespace TicoGrafica.Infrastructure.Migrations
{
    public partial class OrcamentoMaisDeUmProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Produto_IdProduto",
                table: "Orcamento");

            migrationBuilder.DropIndex(
                name: "IX_Orcamento_IdProduto",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "Orcamento");

            migrationBuilder.CreateTable(
                name: "OrcamentoProduto",
                columns: table => new
                {
                    OrcamentosId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProdutosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrcamentoProduto", x => new { x.OrcamentosId, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_OrcamentoProduto_Orcamento_OrcamentosId",
                        column: x => x.OrcamentosId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrcamentoProduto_Produto_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrcamentoProduto_ProdutosId",
                table: "OrcamentoProduto",
                column: "ProdutosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrcamentoProduto");

            migrationBuilder.AddColumn<int>(
                name: "IdProduto",
                table: "Orcamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_IdProduto",
                table: "Orcamento",
                column: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Produto_IdProduto",
                table: "Orcamento",
                column: "IdProduto",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
