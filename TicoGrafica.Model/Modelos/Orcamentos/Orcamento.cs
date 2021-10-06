using System;
using TicoGrafica.Model.Extensoes;
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

        public Orcamento(int idPessoa, int idProduto, int quantidade, double valor, TipoFormaDePagamento formaDePagamento)
        {
            IdPessoa = idPessoa;
            IdProduto = idProduto;
            Quantidade = quantidade;
            Valor = valor;
            FormaDePagamento = formaDePagamento;

            DataCriacao = DateTime.Now.DataTimeZoneCorreto();
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }

        public void Alterar(Orcamento orcamento)
        {
            Valor = orcamento.Valor;
            IdPessoa = orcamento.IdPessoa;
            IdProduto = orcamento.IdProduto;
            Quantidade = orcamento.Quantidade;
            FormaDePagamento = orcamento.FormaDePagamento;

            Pessoa = null;
            Produto = null;

            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }
    }
}
