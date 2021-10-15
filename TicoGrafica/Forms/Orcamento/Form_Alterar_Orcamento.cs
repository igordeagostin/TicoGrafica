using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.Orcamentos;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Orcamento
{
    public partial class Form_Alterar_Orcamento : Form
    {
        private IOrcamentoService _orcamentoService;
        private Form_TelaInicial_Orcamento _telaInicial_Orcamento;
        private readonly IServiceScopeFactory _scopeFactory;
        private IPessoaService _pessoaService;
        private IProdutoService _produtoService;
        private Model.Modelos.Orcamentos.Orcamento _orcamento;

        public Form_Alterar_Orcamento(Form_TelaInicial_Orcamento telaInicial_Orcamento, IServiceScopeFactory scopeFactory, Model.Modelos.Orcamentos.Orcamento orcamento)
        {
            _telaInicial_Orcamento = telaInicial_Orcamento;
            _scopeFactory = scopeFactory;
            _orcamento = orcamento;

            InitializeComponent();
            PreencherComboBox();
            PreencherTelaDeAlteracao();
        }

        private void PreencherTelaDeAlteracao()
        {
            textBoxPessoa.Text = _orcamento.Pessoa.Nome;
            textBoxProduto.Text = _orcamento.Produto.Nome;
            textBoxQuantidade.Text = _orcamento.Quantidade.ToString();
            textBoxValor.Text = _orcamento.Valor.ToString();
            textBoxIdPessoa.Text = _orcamento.IdPessoa.ToString();
            textBoxIdProduto.Text = _orcamento.IdProduto.ToString();
            comboBoxFormaDePagamento.SelectedIndex = (int)_orcamento.FormaDePagamento;
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
            foreach (var tipo in (TipoFormaDePagamento[])Enum.GetValues(typeof(TipoFormaDePagamento)))
            {
                comboBoxFormaDePagamento.Items.Add(EnumHelper<TipoFormaDePagamento>.GetDisplayValue(tipo));
            }
            comboBoxFormaDePagamento.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_LocalizarProduto(_scopeFactory, this).ShowDialog();
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _orcamentoService = scope.ServiceProvider.GetRequiredService<IOrcamentoService>();

                double valor = (string.IsNullOrEmpty(textBoxValor.Text) ? 0 : Convert.ToDouble(textBoxValor.Text));
                var idPessoa = Convert.ToInt32(textBoxIdPessoa.Text);
                var idProduto = Convert.ToInt32(textBoxIdProduto.Text);
                var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                var formaPagamento = (TipoFormaDePagamento)comboBoxFormaDePagamento.SelectedIndex;

                var orcamento = new Model.Modelos.Orcamentos.Orcamento(idPessoa, idProduto, quantidade, valor, formaPagamento);

                _orcamento.Alterar(orcamento);
                _orcamentoService.Alterar(_orcamento);

                this.Visible = false;
            }

            _telaInicial_Orcamento.AtualizarDataGridViewProdutos();
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
