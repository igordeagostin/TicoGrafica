using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Forms.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double? Valor { get; set; }
        public string UnidadeDeMedida { get; set; }
    }
}
