using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.ContasAReceber;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasReceber
{
    public partial class Form_Alterar_ContasReceber : Form
    {
        private IContasReceberService _contasPagarService;
        private Form_TelaInicial_ContasReceber _telaInicial_ContasReceber;
        private readonly IServiceScopeFactory _scopeFactory;
        private IPessoaService _pessoaService;
        private Model.Modelos.ContasAReceber.ContasReceber _contasPagar;

        public Form_Alterar_ContasReceber(Form_TelaInicial_ContasReceber telaInicial_ContasReceber, IServiceScopeFactory scopeFactory, Model.Modelos.ContasAReceber.ContasReceber contasPagar)
        {
            _telaInicial_ContasReceber = telaInicial_ContasReceber;
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
            maskedTextBoxDataDoPedido.Text = _contasPagar.DataDoPedido.ToString();
            maskedTextBoxDataDeVencimento.Text = _contasPagar.DataDeVencimento.ToString();
            comboBoxTipoConta.SelectedIndex = (_contasPagar.Situacao == TipoSituacao.PENDENTE ? 0 : 1);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasReceberService>();

                    double valor = (string.IsNullOrEmpty(textBoxValor.Text) ? 0 : Convert.ToDouble(textBoxValor.Text));
                    var dataDoPedido = Convert.ToDateTime(maskedTextBoxDataDoPedido.Text);
                    var dataDeVencimento = Convert.ToDateTime(maskedTextBoxDataDeVencimento.Text);
                    var idPessoa = Convert.ToInt32(textBoxIdPessoa.Text);

                    var contasPagar = new Model.Modelos.ContasAReceber.ContasReceber(textBoxDescricao.Text, valor,
                        dataDoPedido, dataDeVencimento, idPessoa,
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

            _telaInicial_ContasReceber.AtualizarDataGridViewProdutos();
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
