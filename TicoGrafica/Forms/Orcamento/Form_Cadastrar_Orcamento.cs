using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Orcamento
{
    public partial class Form_Cadastrar_Orcamento : Form
    {
        private IOrcamentoService _orcamentoService;
        private Form_TelaInicial_Orcamento _telaInicial_Orcamento;
        private readonly IServiceScopeFactory _scopeFactory;
        private IPessoaService _pessoaService;
        private IProdutoService _produtoService;

        public Form_Cadastrar_Orcamento(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        public Form_Cadastrar_Orcamento(Form_TelaInicial_Orcamento telaInicial_Orcamento, IServiceScopeFactory scopeFactory)
        {
            _telaInicial_Orcamento = telaInicial_Orcamento;
            _scopeFactory = scopeFactory;

            InitializeComponent();
            PreencherComboBox();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _orcamentoService = scope.ServiceProvider.GetRequiredService<IOrcamentoService>();

                double valor = (string.IsNullOrEmpty(textBoxValor.Text) ? 0 : Convert.ToDouble(textBoxValor.Text));
                var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                var formaPagamento = (Model.Modelos.Orcamentos.TipoFormaDePagamento)comboBoxFormaDePagamento.SelectedIndex;
                var idPessoa = Convert.ToInt32(textBoxIdPessoa.Text);
                var idProduto = Convert.ToInt32(textBoxIdProduto.Text);

                var orcamento = new Model.Modelos.Orcamentos.Orcamento(idPessoa, idProduto, quantidade, valor, formaPagamento);

                _orcamentoService.Adicionar(orcamento);
                this.Visible = false;
            }

            _telaInicial_Orcamento.AtualizarDataGridViewProdutos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonBuscarPessoa_Click(object sender, EventArgs e)
        {
            new Form_LocalizarPessoa(_scopeFactory, this).ShowDialog();
        }

        public void SetarPessoa(int idPessoa)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _pessoaService = scope.ServiceProvider.GetRequiredService<IPessoaService>();

                var pessoa = _pessoaService.BuscarPorId(idPessoa);

                textBoxPessoa.Text = pessoa.Nome;
                textBoxIdPessoa.Text = idPessoa.ToString();
            }
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

        private void PreencherComboBox()
        {
            foreach (var tipo in (Model.Modelos.Orcamentos.TipoFormaDePagamento[])Enum.GetValues(typeof(Model.Modelos.Orcamentos.TipoFormaDePagamento)))
            {
                comboBoxFormaDePagamento.Items.Add(EnumHelper<Model.Modelos.Orcamentos.TipoFormaDePagamento>.GetDisplayValue(tipo));
            }
            comboBoxFormaDePagamento.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_LocalizarProduto(_scopeFactory, this).ShowDialog();
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
