using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.ContasAPagar;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasPagar
{
    public partial class Form_Alterar_ContasPagar : Form
    {
        private IContasPagarService _contasPagarService;
        private Form_TelaInicial_ContasPagar _telaInicial_ContasPagar;
        private readonly IServiceScopeFactory _scopeFactory;
        private IPessoaService _pessoaService;
        private Model.Modelos.ContasAPagar.ContasPagar _contasPagar;

        public Form_Alterar_ContasPagar(Form_TelaInicial_ContasPagar telaInicial_ContasPagar, IServiceScopeFactory scopeFactory, Model.Modelos.ContasAPagar.ContasPagar contasPagar)
        {
            _telaInicial_ContasPagar = telaInicial_ContasPagar;
            _scopeFactory = scopeFactory;
            _contasPagar = contasPagar;

            InitializeComponent();
            PreencherComboBox();
            PreencherTelaDeAlteracao();
        }

        private void PreencherTelaDeAlteracao()
        {
            textBoxNome.Text = _contasPagar.Pessoa.Nome;
            textBoxDescricao.Text = _contasPagar.Descricao;
            textBoxValor.Text = _contasPagar.Valor.ToString();
            textBoxIdPessoa.Text = _contasPagar.IdPessoa.ToString();
            maskedTextBoxDataDeVencimento.Text = _contasPagar.DataDeVencimento.ToString();
            comboBoxTipoConta.SelectedIndex = (_contasPagar.Situacao == TipoSituacao.PENDENTE ? 0 : 1);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasPagarService>();

                    double valor = (string.IsNullOrEmpty(textBoxValor.Text) ? 0 : Convert.ToDouble(textBoxValor.Text));
                    var dataDeVencimento = Convert.ToDateTime(maskedTextBoxDataDeVencimento.Text);
                    var idPessoa = Convert.ToInt32(textBoxIdPessoa.Text);

                    var contasPagar = new Model.Modelos.ContasAPagar.ContasPagar(textBoxDescricao.Text, valor,
                          dataDeVencimento, idPessoa,
                        (comboBoxTipoConta.SelectedIndex == 0 ? TipoSituacao.PENDENTE : TipoSituacao.QUITADO));

                    _contasPagar.Alterar(contasPagar);
                    _contasPagarService.Alterar(_contasPagar);

                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _telaInicial_ContasPagar.AtualizarDataGridViewProdutos();
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

                textBoxNome.Text = pessoa.Nome;
                textBoxIdPessoa.Text = idPessoa.ToString();
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

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
