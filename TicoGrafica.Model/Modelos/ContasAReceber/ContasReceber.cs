using System;
using TicoGrafica.Model.Extensoes;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Model.Modelos.ContasAReceber
{
    public class ContasReceber : Entidade
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataDeEntrega { get; private set; }
        public DateTime DataDeVencimento { get; private set; }
        public int IdPessoa { get; private set; }
        public TipoSituacao Situacao { get; private set; }
        public virtual Pessoa Pessoa { get; set; }

        public ContasReceber()
        {

        }
        public ContasReceber(string descricao, double valor, DateTime dataDeEntrega, DateTime dataDeVencimento, int idPessoa, TipoSituacao situacao)
        {
            Descricao = descricao;
            Valor = valor;
            DataDeEntrega = dataDeEntrega;
            DataDeVencimento = dataDeVencimento;
            IdPessoa = idPessoa;
            Situacao = situacao;

            DataCriacao = DateTime.Now.DataTimeZoneCorreto();
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }

        public void Alterar(ContasReceber contasReceber)
        {
            Descricao = contasReceber.Descricao;
            Valor = contasReceber.Valor;
            DataDeEntrega = contasReceber.DataDeEntrega;
            DataDeVencimento = contasReceber.DataDeVencimento;
            IdPessoa = contasReceber.IdPessoa;
            Situacao = contasReceber.Situacao;

            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }

        public void QuitarConta()
        {
            this.Situacao = TipoSituacao.QUITADO;
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }

        public void AbrirConta()
        {
            this.Situacao = TipoSituacao.PENDENTE;
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }
    }
}
