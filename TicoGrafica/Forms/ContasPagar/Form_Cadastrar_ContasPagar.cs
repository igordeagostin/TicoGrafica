using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Produtos;
using TicoGrafica.Model.Modelos.Produtos;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasPagar
{
    public partial class Form_Cadastrar_ContasPagar : Form
    {
        private IProdutoService _produtoService;
        private Form_TelaInicial_ContasPagar _telaInicial_ContasPagar;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_Cadastrar_ContasPagar(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        public Form_Cadastrar_ContasPagar(Form_TelaInicial_ContasPagar telaInicial_ContasPagar, IServiceScopeFactory scopeFactory)
        {
            _telaInicial_ContasPagar = telaInicial_ContasPagar;
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                var produto = new Produto(textBoxNome.Text,
                    (string.IsNullOrEmpty(textBoxValor.Text) ? null : (double?)Convert.ToDouble(textBoxValor.Text)));

                _produtoService.Adicionar(produto);
                this.Visible = false;
            }

            _telaInicial_ContasPagar.AtualizarDataGridViewProdutos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonBuscarPessoa_Click(object sender, EventArgs e)
        {
            new Form_LocalizarPessoa(_scopeFactory).ShowDialog();
        }
    }
}
