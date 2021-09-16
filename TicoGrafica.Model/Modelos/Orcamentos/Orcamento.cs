using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Model.Modelos.Orcamentos
{
    public class Orcamento : Entidade
    {
        public int IdPessoa { get; private set; }
        public int IdProduto { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }
        public TipoFormaDePagamento FormaDePagamento { get; private set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Produto Produto { get; set; }

        public Orcamento()
        {

        }
    }
}
