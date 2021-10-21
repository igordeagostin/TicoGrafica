using System;
using TicoGrafica.Model.Extensoes;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Model.Modelos.ContasAPagar
{
    public class ContasPagar : Entidade
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataDeVencimento { get; private set; }
        public int IdPessoa { get; private set; }
        public TipoSituacao Situacao { get; private set; }
        public virtual Pessoa Pessoa { get; set; }
        public ContasPagar()
        {

        }
        public ContasPagar(string descricao, double valor, DateTime dataDeVencimento, int idPessoa, TipoSituacao situacao)
        {
            Descricao = descricao;
            Valor = valor;
            DataDeVencimento = dataDeVencimento;
            IdPessoa = idPessoa;
            Situacao = situacao;

            DataCriacao = DateTime.Now.DataTimeZoneCorreto();
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();

            EstaValido();
        }

        public void Alterar(ContasPagar contasReceber)
        {
            Descricao = contasReceber.Descricao;
            Valor = contasReceber.Valor;
            DataDeVencimento = contasReceber.DataDeVencimento;
            IdPessoa = contasReceber.IdPessoa;
            Situacao = contasReceber.Situacao;
            Pessoa = null;

            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();

            EstaValido();
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

        public void AdicionarTempo(int medida, int quantidadeParaAdicionar)
        {
            if (medida == 0)
            {
                this.DataDeVencimento = this.DataDeVencimento.AddDays(quantidadeParaAdicionar);
            }
            else
            {
                this.DataDeVencimento = this.DataDeVencimento.AddMonths(quantidadeParaAdicionar);
            }
        }

        private void EstaValido()
        {
            if (this.Valor <= 0)
            {
                throw new ArgumentException("O valor deve ser maior do que zero.");
            }

            if (IdPessoa <= 0)
            {
                throw new ArgumentException("É necessário selecionar uma pessoa.");
            }
        }
    }
}
