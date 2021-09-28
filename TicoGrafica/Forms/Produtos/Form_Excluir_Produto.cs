using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Shared;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Produtos
{
    public partial class Form_Excluir_Produto : Form
    {
        private Form_TelaInicial_Produtos _form_TelaInicial_Produtos;
        private IServiceScopeFactory _scopeFactory;
        private IProdutoService _produtoService;
        public Form_Excluir_Produto(IServiceScopeFactory scopeFactory, Form_TelaInicial_Produtos form_TelaInicial_Produtos)
        {
            _form_TelaInicial_Produtos = form_TelaInicial_Produtos;
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                    var id = _form_TelaInicial_Produtos.RecuperarLinhaSelecionada();
                    _produtoService.Excluir(id);
                }

                _form_TelaInicial_Produtos.AtualizarDataGridViewProdutos();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                this.Visible = false;
                new Form_TelaDeErro("Ocorreu um erro ao excluir este produto. Erro: " + ex.Message)
                    .ShowDialog();
            }
        }
    }
}
