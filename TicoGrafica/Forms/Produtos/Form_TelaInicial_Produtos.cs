using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Model.Modelos.Produtos;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Produtos
{
    public partial class Form_TelaInicial_Produtos : Form
    {
        private IProdutoService _produtoService;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_TelaInicial_Produtos(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            new Form_Cadastrar_Produto(this, _scopeFactory).ShowDialog();
        }

        private void Form_TelaInicial_Produtos_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewProdutos();
        }

        private void buttonAlterarPessoa_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();
                var produto = _produtoService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_Produto(this, _scopeFactory, produto).ShowDialog();
            }
        }

        public void AtualizarDataGridViewProdutos()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                var produtos = _produtoService
                .BuscarTodos()
                .Select(x => new ProdutoDTO
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Valor = x.Valor,
                    UnidadeDeMedida = EnumHelper<TipoUnidadeDeMedida>.GetDisplayValue(x.UnidadeDeMedida),
                })
                .ToList();

                this.dataGridViewProdutos.DataSource = produtos;

                this.dataGridViewProdutos.Columns["Id"].HeaderText = "ID";
                this.dataGridViewProdutos.Columns["Id"].DisplayIndex = 0;
                this.dataGridViewProdutos.Columns["Id"].Visible = false;

                this.dataGridViewProdutos.Columns["Nome"].HeaderText = "NOME";
                this.dataGridViewProdutos.Columns["Nome"].DisplayIndex = 1;

                this.dataGridViewProdutos.Columns["Valor"].HeaderText = "VALOR";
                this.dataGridViewProdutos.Columns["Valor"].DisplayIndex = 2;

                this.dataGridViewProdutos.Columns["UnidadeDeMedida"].HeaderText = "MEDIDA";
                this.dataGridViewProdutos.Columns["UnidadeDeMedida"].DisplayIndex = 3;

                this.dataGridViewProdutos.Update();
                this.dataGridViewProdutos.Refresh();
            }
        }

        public int RecuperarLinhaSelecionada()
        {
            var linhasSelecionadas = this.dataGridViewProdutos.SelectedRows;
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
            new Form_Excluir_Produto(_scopeFactory, this).ShowDialog();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();
                var produto = _produtoService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_Produto(this, _scopeFactory, produto).ShowDialog();
            }
        }

        private void dataGridViewProdutos_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                new Form_Excluir_Produto(_scopeFactory, this).ShowDialog();
            }
        }
    }
}
