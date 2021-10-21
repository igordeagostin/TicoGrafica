using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.Produtos;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Produtos
{
    public partial class Form_Cadastrar_Produto : Form
    {
        private IProdutoService _produtoService;
        private Form_TelaInicial_Produtos _telaInicial_Produtos;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_Cadastrar_Produto(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        public Form_Cadastrar_Produto(Form_TelaInicial_Produtos telaInicial_Produtos, IServiceScopeFactory scopeFactory)
        {
            _telaInicial_Produtos = telaInicial_Produtos;
            _scopeFactory = scopeFactory;
            InitializeComponent();
            PreencherComboBox();
        }

        private void PreencherComboBox()
        {
            foreach (var tipo in (TipoUnidadeDeMedida[])Enum.GetValues(typeof(TipoUnidadeDeMedida)))
            {
                comboBoxUnidadeDeMedida.Items.Add(EnumHelper<TipoUnidadeDeMedida>.GetDisplayValue(tipo));
            }
            comboBoxUnidadeDeMedida.SelectedIndex = 0;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _produtoService = scope.ServiceProvider.GetRequiredService<IProdutoService>();

                var produto = new Produto(textBoxNome.Text,
                    (string.IsNullOrEmpty(textBoxValor.Text) ? null : (double?)Convert.ToDouble(textBoxValor.Text.Replace(".", ","))), TipoUnidadeDeMedida.HORA);

                _produtoService.Adicionar(produto);
                this.Visible = false;
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
