using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.Produtos;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Produtos
{
    public partial class Form_Alterar_Produto : Form
    {
        private IProdutoService _produtoService;
        private Form_TelaInicial_Produtos _telaInicial_Produtos;
        private readonly IServiceScopeFactory _scopeFactory;
        private Produto _produto;

        public Form_Alterar_Produto(Form_TelaInicial_Produtos telaInicial_Produtos, IServiceScopeFactory scopeFactory, Produto produto)
        {
            _telaInicial_Produtos = telaInicial_Produtos;
            _scopeFactory = scopeFactory;
            _produto = produto;

            InitializeComponent();
            PreencherTelaDeAlteracao();
        }

        private void PreencherTelaDeAlteracao()
        {
            textBoxNome.Text = _produto.Nome;
            textBoxValor.Text = (_produto.Valor == null ? "" : _produto.Valor.ToString());
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                var produto = new Produto(textBoxNome.Text,
                    (string.IsNullOrEmpty(textBoxValor.Text) ? null : (double?)Convert.ToDouble(textBoxValor.Text.Replace(".", ","))));

                _produto.Alterar(produto);

                _produtoService.Alterar(_produto);
                this.Dispose();
            }

            _telaInicial_Produtos.AtualizarDataGridViewProdutos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
