using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Orcamento
{
    public partial class Form_Inserir_Produto : Form
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private IProdutoService _produtoService;
        Form_Cadastrar_Orcamento _form_Cadastrar_Orcamento;

        public Form_Inserir_Produto(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        public Form_Inserir_Produto(IServiceScopeFactory scopeFactory, Form_Cadastrar_Orcamento form_Cadastrar_Orcamento)
        {
            _scopeFactory = scopeFactory;
            _form_Cadastrar_Orcamento = form_Cadastrar_Orcamento;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_LocalizarProduto(_scopeFactory, this).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SetarProduto(int idProduto)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                var produto = _produtoService.BuscarPorId(idProduto);

                textBoxProduto.Text = produto.Nome;
                textBoxIdProduto.Text = idProduto.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form_Cadastrar_Orcamento.InserirProduto(Convert.ToInt32(textBoxIdProduto.Text),
                Convert.ToInt32(textBoxQuantidade.Text), Convert.ToInt32(textBoxValor.Text));
            this.Dispose();
        }
    }
}
