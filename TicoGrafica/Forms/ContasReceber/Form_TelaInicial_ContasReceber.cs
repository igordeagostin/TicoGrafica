using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasReceber
{
    public partial class Form_TelaInicial_ContasReceber : Form
    {
        private IContasReceberService _contasPagarService;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_TelaInicial_ContasReceber(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            new Form_Cadastrar_ContasReceber(this, _scopeFactory).ShowDialog();
        }

        private void Form_TelaInicial_Produtos_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewProdutos();
        }

        private void buttonAlterarPessoa_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasReceberService>();
                var contasAPagar = _contasPagarService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_ContasReceber(this, _scopeFactory, contasAPagar).ShowDialog();
            }
        }

        public void AtualizarDataGridViewProdutos()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasReceberService>();

                var contasPagar = _contasPagarService
                .BuscarTodos()
                .Select(x => new ContasReceberDTO
                {
                    Id = x.Id,
                    DataDoPedido = x.DataDoPedido,
                    DataDeVencimento = x.DataDeVencimento,
                    Descricao = x.Descricao,
                    Situacao = x.Situacao,
                    IdPessoa = (x.Pessoa == null ? 0 : x.Pessoa.Id),
                    NomePessoa = x.Pessoa?.Nome,
                    Valor = x.Valor
                })
                .ToList();

                this.dataGridViewContasReceber.DataSource = contasPagar;

                this.dataGridViewContasReceber.Columns["Id"].HeaderText = "ID";
                this.dataGridViewContasReceber.Columns["Id"].DisplayIndex = 0;
                this.dataGridViewContasReceber.Columns["Id"].Visible = false;

                this.dataGridViewContasReceber.Columns["Situacao"].HeaderText = "SITUAÇÃO";
                this.dataGridViewContasReceber.Columns["Situacao"].DisplayIndex = 1;

                this.dataGridViewContasReceber.Columns["Descricao"].HeaderText = "DESCRIÇÃO";
                this.dataGridViewContasReceber.Columns["Descricao"].DisplayIndex = 2;

                this.dataGridViewContasReceber.Columns["Valor"].HeaderText = "VALOR";
                this.dataGridViewContasReceber.Columns["Valor"].DisplayIndex = 3;

                this.dataGridViewContasReceber.Columns["NomePessoa"].HeaderText = "PESSOA";
                this.dataGridViewContasReceber.Columns["NomePessoa"].DisplayIndex = 4;

                this.dataGridViewContasReceber.Columns["DataDoPedido"].HeaderText = "DATA DO PEDIDO";
                this.dataGridViewContasReceber.Columns["DataDoPedido"].DisplayIndex = 5;

                this.dataGridViewContasReceber.Columns["DataDeVencimento"].HeaderText = "DATA DE VENCIMENTO";
                this.dataGridViewContasReceber.Columns["DataDeVencimento"].DisplayIndex = 6;

                this.dataGridViewContasReceber.Columns["IdPessoa"].HeaderText = "ID";
                this.dataGridViewContasReceber.Columns["IdPessoa"].DisplayIndex = 7;
                this.dataGridViewContasReceber.Columns["IdPessoa"].Visible = false;

                this.dataGridViewContasReceber.Update();
                this.dataGridViewContasReceber.Refresh();
            }
        }

        public int RecuperarLinhaSelecionada()
        {
            var linhasSelecionadas = this.dataGridViewContasReceber.SelectedRows;
            if (linhasSelecionadas.Count > 0)
            {
                var idProduto = linhasSelecionadas[0].Cells[0].Value;

                if (idProduto != null)
                {
                    return Convert.ToInt32(idProduto);
                }
            }
            return 0;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            new Form_Excluir_ContasReceber(_scopeFactory, this).ShowDialog();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasReceberService>();
                var contasAPagar = _contasPagarService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_ContasReceber(this, _scopeFactory, contasAPagar).ShowDialog();
            }
        }

        private void dataGridViewProdutos_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                new Form_Excluir_ContasReceber(_scopeFactory, this).ShowDialog();
            }
        }

        private void dataGridViewContasReceber_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridViewContasReceber.Rows[e.RowIndex].Cells["Situacao"].Value.ToString() == "PENDENTE" &&
                Convert.ToDateTime(dataGridViewContasReceber.Rows[e.RowIndex].Cells["DataDeVencimento"].Value.ToString()) < DateTime.Now)
            {
                dataGridViewContasReceber.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
            }
        }
    }
}
