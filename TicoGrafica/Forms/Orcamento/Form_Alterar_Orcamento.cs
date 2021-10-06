using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.ContasAReceber;
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
            textBoxValor.Text = _orcamento.Valor.ToString();
            textBoxIdPessoa.Text = _orcamento.IdPessoa.ToString();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _orcamentoService = scope.ServiceProvider.GetRequiredService<IOrcamentoService>();

                double valor = (string.IsNullOrEmpty(textBoxValor.Text) ? 0 : Convert.ToDouble(textBoxValor.Text));
                var dataDeEntrega = Convert.ToDateTime(maskedTextBoxDataDeEntrega.Text);
                var dataDeVencimento = Convert.ToDateTime(maskedTextBoxDataDeVencimento.Text);
                var idPessoa = Convert.ToInt32(textBoxIdPessoa.Text);

                //var orcamento = new Model.Modelos.Orcamentos.Orcamento(textBoxDescricao.Text, valor,
                //    dataDeEntrega, dataDeVencimento, idPessoa,
                //    (comboBoxTipoConta.SelectedIndex == 0 ? TipoSituacao.PENDENTE : TipoSituacao.QUITADO));

                //_orcamento.Alterar(orcamento);
                _orcamentoService.Alterar(_orcamento);

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
            foreach (var tipo in (TipoSituacao[])Enum.GetValues(typeof(TipoSituacao)))
            {
                comboBoxTipoConta.Items.Add(EnumHelper<TipoSituacao>.GetDisplayValue(tipo));
            }
            comboBoxTipoConta.SelectedIndex = 0;
        }
    }
}
