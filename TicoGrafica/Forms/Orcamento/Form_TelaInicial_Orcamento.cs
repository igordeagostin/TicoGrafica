using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Orcamento
{
    public partial class Form_TelaInicial_Orcamento : Form
    {
        private IOrcamentoService _orcamentoService;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_TelaInicial_Orcamento(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            new Form_Cadastrar_Orcamento(this, _scopeFactory).ShowDialog();
        }

        private void Form_TelaInicial_Produtos_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewProdutos();
        }

        private void buttonAlterarPessoa_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _orcamentoService = scope.ServiceProvider.GetRequiredService<IOrcamentoService>();
                var contasAPagar = _orcamentoService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_Orcamento(this, _scopeFactory, contasAPagar).ShowDialog();
            }
        }

        public void AtualizarDataGridViewProdutos()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _orcamentoService = scope.ServiceProvider.GetRequiredService<IOrcamentoService>();

                var orcamento = _orcamentoService
                .BuscarTodos()
                .Select(x => new OrcamentoDTO
                {
                    Id = x.Id,
                    IdPessoa = (x.Pessoa == null ? 0 : x.Pessoa.Id),
                    IdProduto = (x.Produto == null ? 0 : x.Produto.Id),
                    NomePessoa = x.Pessoa?.Nome,
                    NomeProduto = x.Produto?.Nome,
                    Valor = x.Valor,
                    Quantidade = x.Quantidade
                })
                .ToList();

                this.dataGridViewOrcamento.DataSource = orcamento;

                this.dataGridViewOrcamento.Columns["Id"].HeaderText = "ID";
                this.dataGridViewOrcamento.Columns["Id"].DisplayIndex = 0;
                this.dataGridViewOrcamento.Columns["Id"].Visible = false;

                this.dataGridViewOrcamento.Columns["Quantidade"].HeaderText = "QUANTIDADE";
                this.dataGridViewOrcamento.Columns["Quantidade"].DisplayIndex = 1;

                this.dataGridViewOrcamento.Columns["Valor"].HeaderText = "VALOR";
                this.dataGridViewOrcamento.Columns["Valor"].DisplayIndex = 2;

                this.dataGridViewOrcamento.Columns["FormaDePagamento"].HeaderText = "FORMA DE PAGAMENTO";
                this.dataGridViewOrcamento.Columns["FormaDePagamento"].DisplayIndex = 3;

                this.dataGridViewOrcamento.Columns["IdPessoa"].HeaderText = "ID";
                this.dataGridViewOrcamento.Columns["IdPessoa"].DisplayIndex = 4;
                this.dataGridViewOrcamento.Columns["IdPessoa"].Visible = false;

                this.dataGridViewOrcamento.Columns["IdProduto"].HeaderText = "ID";
                this.dataGridViewOrcamento.Columns["IdProduto"].DisplayIndex = 5;
                this.dataGridViewOrcamento.Columns["IdProduto"].Visible = false;

                this.dataGridViewOrcamento.Update();
                this.dataGridViewOrcamento.Refresh();
            }
        }

        public int RecuperarLinhaSelecionada()
        {
            var linhasSelecionadas = this.dataGridViewOrcamento.SelectedRows;
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
            new Form_Excluir_Orcamento(_scopeFactory, this).ShowDialog();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _orcamentoService = scope.ServiceProvider.GetRequiredService<IOrcamentoService>();
                var contasAPagar = _orcamentoService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_Orcamento(this, _scopeFactory, contasAPagar).ShowDialog();
            }
        }

        private void dataGridViewProdutos_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                new Form_Excluir_Orcamento(_scopeFactory, this).ShowDialog();
            }
        }
    }
}
