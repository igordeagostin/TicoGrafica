using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Orcamento
{
    public partial class Form_LocalizarProduto : Form
    {
        private IProdutoService _produtoService;
        private readonly IServiceScopeFactory _scopeFactory;
        private Form_Cadastrar_Orcamento _form_Cadastrar_Orcamento;
        private Form_Alterar_Orcamento _form_Alterar_Orcamento;
        private Form_Inserir_Produto _form_Inserir_Produto;
        public Form_LocalizarProduto(IServiceScopeFactory scopeFactory, Form_Cadastrar_Orcamento form_Cadastrar_Orcamento)
        {
            _scopeFactory = scopeFactory;
            _form_Cadastrar_Orcamento = form_Cadastrar_Orcamento;

            InitializeComponent();

            this.ActiveControl = textBoxPesquisar;
        }

        public Form_LocalizarProduto(IServiceScopeFactory scopeFactory, Form_Inserir_Produto form_Inserir_Produto)
        {
            _scopeFactory = scopeFactory;
            _form_Inserir_Produto = form_Inserir_Produto;

            InitializeComponent();

            this.ActiveControl = textBoxPesquisar;
        }

        public Form_LocalizarProduto(IServiceScopeFactory scopeFactory, Form_Alterar_Orcamento form_Alterar_Orcamento)
        {
            _scopeFactory = scopeFactory;
            _form_Alterar_Orcamento = form_Alterar_Orcamento;

            InitializeComponent();

            this.ActiveControl = textBoxPesquisar;
        }

        private void Form_LocalizarPessoa_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewPessoas(RetornarListaInicialDePessoas());
        }

        private List<ProdutoDTO> RetornarListaInicialDePessoas()
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
                    Valor = x.Valor
                })
                .ToList();

                return produtos;
            }
        }

        private List<ProdutoDTO> RetornarListaDePessoasPesquisadas(string texto)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                var produtos = _produtoService
                .BuscarPorNome(texto)
                .Select(x => new ProdutoDTO
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Valor = x.Valor
                })
                .ToList();

                return produtos;
            }
        }

        public void AtualizarDataGridViewPessoas(List<ProdutoDTO> produtos)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                this.dataGridViewProdutos.DataSource = produtos;

                this.dataGridViewProdutos.Columns["Id"].HeaderText = "ID";
                this.dataGridViewProdutos.Columns["Id"].DisplayIndex = 0;
                this.dataGridViewProdutos.Columns["Id"].Visible = false;

                this.dataGridViewProdutos.Columns["Nome"].HeaderText = "NOME";
                this.dataGridViewProdutos.Columns["Nome"].DisplayIndex = 1;

                this.dataGridViewProdutos.Columns["Valor"].HeaderText = "VALOR";
                this.dataGridViewProdutos.Columns["Valor"].DisplayIndex = 2;

                this.dataGridViewProdutos.Update();
                this.dataGridViewProdutos.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizarDataGridViewPessoas(RetornarListaDePessoasPesquisadas(textBoxPesquisar.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

        public int RecuperarLinhaSelecionada()
        {
            var linhasSelecionadas = this.dataGridViewProdutos.SelectedRows;
            if (linhasSelecionadas.Count > 0)
            {
                var idPessoa = linhasSelecionadas[0].Cells[0].Value;

                if (idPessoa != null)
                {
                    return Convert.ToInt32(idPessoa);
                }
            }
            return 0;
        }

        private void SelecionarProduto()
        {
            var idProduto = RecuperarLinhaSelecionada();

            if (idProduto == 0)
            {
                MessageBox.Show("Por favor, seleciona um produto.");
            }
            else if (_form_Inserir_Produto != null)
            {
                _form_Inserir_Produto.SetarProduto(idProduto);
                this.Dispose();
            }
        }

        private void dataGridViewPessoas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelecionarProduto();
        }
    }
}
