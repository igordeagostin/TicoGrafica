using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_Cadastrar_Pessoa : Form
    {
        private IPessoaService _pessoaService;
        private Form_TelaInicial_Pessoas _telaInicial_Pessoas;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_Cadastrar_Pessoa(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        public Form_Cadastrar_Pessoa(Form_TelaInicial_Pessoas telaInicial_Pessoas, IServiceScopeFactory scopeFactory)
        {
            _telaInicial_Pessoas = telaInicial_Pessoas;
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    _pessoaService = scope.ServiceProvider.GetRequiredService<IPessoaService>();

                    var pessoa = new Pessoa(textBoxNome.Text, maskedTextBoxCelular.Text, maskedTextBoxTelefone.Text, textBoxEmail.Text,
                  (radioButtonFisica.Checked ? TipoPessoa.FISICA : TipoPessoa.JURIDICA), maskedTextBoxDocumento.Text,
                  maskedTextBoxDocumento.Text, new EnderecoPessoa(textBoxEndereco.Text, textBoxNumero.Text, textBoxNumero.Text,
                  textBoxComplemento.Text, textBoxMunicipio.Text, maskedTextBoxCEP.Text));

                    _pessoaService.Adicionar(pessoa);
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            _telaInicial_Pessoas.AtualizarDataGridViewPessoas();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void radioButtonJuridica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDocumento.Mask = @"99\.999\.999/9999-99";
        }

        private void radioButtonFisica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDocumento.Mask = @"999\.999\.999-99";
        }
    }
}
