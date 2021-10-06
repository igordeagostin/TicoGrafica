using TicoGrafica.Model.Modelos.Orcamentos;

namespace TicoGrafica.Forms.DTOs
{
    public class OrcamentoDTO
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public TipoFormaDePagamento FormaDePagamento { get; set; }
        public string NomePessoa { get; set; }
        public string NomeProduto { get; set; }
    }
}
