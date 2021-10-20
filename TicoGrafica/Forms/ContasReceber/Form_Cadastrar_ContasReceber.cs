using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.ContasAReceber;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasReceber
{
    public partial class Form_Cadastrar_ContasReceber : Form
    {
        private IContasReceberService _contasPagarService;
        private Form_TelaInicial_ContasReceber _telaInicial_ContasReceber;
        private readonly IServiceScopeFactory _scopeFactory;
        private IPessoaService _pessoaService;

        public Form_Cadastrar_ContasReceber(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        public Form_Cadastrar_ContasReceber(Form_TelaInicial_ContasReceber telaInicial_ContasReceber, IServiceScopeFactory scopeFactory)
        {
            _telaInicial_ContasReceber = telaInicial_ContasReceber;
            _scopeFactory = scopeFactory;

            InitializeComponent();
            PreencherComboBox();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasReceberService>();

                    double valor = (string.IsNullOrEmpty(textBoxValor.Text) ? 0 : Convert.ToDouble(textBoxValor.Text));
                    var dataDeEntrega = Convert.ToDateTime(maskedTextBoxDataDeEntrega.Text);
                    var dataDeVencimento = Convert.ToDateTime(maskedTextBoxDataDeVencimento.Text);
                    var idPessoa = Convert.ToInt32(textBoxIdPessoa.Text);

                    var contasPagar = new Model.Modelos.ContasAReceber.ContasReceber(textBoxDescricao.Text, valor,
                        dataDeEntrega, dataDeVencimento, idPessoa,
                        (comboBoxTipoConta.SelectedIndex == 0 ? TipoSituacao.PENDENTE : TipoSituacao.QUITADO));

                    _contasPagarService.Adicionar(contasPagar);

                    CadastrarVarios(valor, dataDeEntrega, dataDeVencimento, idPessoa);

                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _telaInicial_ContasReceber.AtualizarDataGridViewProdutos();
        }

        private void CadastrarVarios(double valor, DateTime dataDeEntrega, DateTime dataDeVencimento, int idPessoa)
        {
            if (checkBoxCadastrarVarios.Checked && !string.IsNullOrEmpty(textBoxQuantidadeRepetir.Text) && Convert.ToInt32(textBoxQuantidadeRepetir.Text) > 0)
            {
                for (int contador = 1; contador <= Convert.ToInt32(textBoxQuantidadeRepetir.Text); contador++)
                {
                    var novaConta = new Model.Modelos.ContasAReceber.ContasReceber(textBoxDescricao.Text, valor,
                        dataDeEntrega, dataDeVencimento, idPessoa,
                        (comboBoxTipoConta.SelectedIndex == 0 ? TipoSituacao.PENDENTE : TipoSituacao.QUITADO));

                    novaConta.AdicionarTempo(comboBoxFrequenciaRepetir.SelectedIndex, contador);

                    _contasPagarService.Adicionar(novaConta);
                }
            }
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

        private void checkBoxCadastrarVarios_CheckedChanged(object sender, EventArgs e)
        {
            textBoxQuantidadeRepetir.Enabled = checkBoxCadastrarVarios.Checked;
            comboBoxFrequenciaRepetir.Enabled = checkBoxCadastrarVarios.Checked;
            labelFrequenciaRepetir.Enabled = checkBoxCadastrarVarios.Checked;
            labelQuantidadeRepetir.Enabled = checkBoxCadastrarVarios.Checked;
        }

        private void textBoxQuantidadeRepetir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
