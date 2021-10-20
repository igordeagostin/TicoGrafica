using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasPagar
{
    public partial class Form_TelaInicial_ContasPagar : Form
    {
        private IContasPagarService _contasPagarService;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_TelaInicial_ContasPagar(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            new Form_Cadastrar_ContasPagar(this, _scopeFactory).ShowDialog();
        }

        private void Form_TelaInicial_Produtos_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewProdutos();
        }

        private void buttonAlterarPessoa_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasPagarService>();
                var contasAPagar = _contasPagarService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_ContasPagar(this, _scopeFactory, contasAPagar).ShowDialog();
            }
        }

        public void AtualizarDataGridViewProdutos()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasPagarService>();

                var contasPagar = _contasPagarService
                .BuscarTodos()
                .Select(x => new ContasPagarDTO
                {
                    Id = x.Id,
                    DataDeEntrega = x.DataDeEntrega,
                    DataDeVencimento = x.DataDeVencimento,
                    Descricao = x.Descricao,
                    Situacao = x.Situacao,
                    IdPessoa = (x.Pessoa == null ? 0 : x.Pessoa.Id),
                    NomePessoa = x.Pessoa?.Nome,
                    Valor = x.Valor
                })
                .ToList();

                this.dataGridViewContasPagar.DataSource = contasPagar;

                this.dataGridViewContasPagar.Columns["Id"].HeaderText = "ID";
                this.dataGridViewContasPagar.Columns["Id"].DisplayIndex = 0;
                this.dataGridViewContasPagar.Columns["Id"].Visible = false;

                this.dataGridViewContasPagar.Columns["Situacao"].HeaderText = "SITUAÇÃO";
                this.dataGridViewContasPagar.Columns["Situacao"].DisplayIndex = 1;

                this.dataGridViewContasPagar.Columns["Descricao"].HeaderText = "DESCRIÇÃO";
                this.dataGridViewContasPagar.Columns["Descricao"].DisplayIndex = 2;

                this.dataGridViewContasPagar.Columns["Valor"].HeaderText = "VALOR";
                this.dataGridViewContasPagar.Columns["Valor"].DisplayIndex = 3;

                this.dataGridViewContasPagar.Columns["NomePessoa"].HeaderText = "PESSOA";
                this.dataGridViewContasPagar.Columns["NomePessoa"].DisplayIndex = 4;

                this.dataGridViewContasPagar.Columns["DataDeEntrega"].HeaderText = "DATA DE ENTREGA";
                this.dataGridViewContasPagar.Columns["DataDeEntrega"].DisplayIndex = 5;

                this.dataGridViewContasPagar.Columns["DataDeVencimento"].HeaderText = "DATA DE VENCIMENTO";
                this.dataGridViewContasPagar.Columns["DataDeVencimento"].DisplayIndex = 6;

                this.dataGridViewContasPagar.Columns["IdPessoa"].HeaderText = "ID";
                this.dataGridViewContasPagar.Columns["IdPessoa"].DisplayIndex = 7;
                this.dataGridViewContasPagar.Columns["IdPessoa"].Visible = false;

                this.dataGridViewContasPagar.Update();
                this.dataGridViewContasPagar.Refresh();
            }
        }

        public int RecuperarLinhaSelecionada()
        {
            var linhasSelecionadas = this.dataGridViewContasPagar.SelectedRows;
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
            new Form_Excluir_ContasPagar(_scopeFactory, this).ShowDialog();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasPagarService>();
                var contasAPagar = _contasPagarService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_ContasPagar(this, _scopeFactory, contasAPagar).ShowDialog();
            }
        }

        private void dataGridViewProdutos_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                new Form_Excluir_ContasPagar(_scopeFactory, this).ShowDialog();
            }
        }

        private void dataGridViewContasPagar_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridViewContasPagar.Rows[e.RowIndex].Cells["Situacao"].Value.ToString() == "PENDENTE" &&
               Convert.ToDateTime(dataGridViewContasPagar.Rows[e.RowIndex].Cells["DataDeVencimento"].Value.ToString()) < DateTime.Now)
            {
                dataGridViewContasPagar.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
            }
        }
    }
}
