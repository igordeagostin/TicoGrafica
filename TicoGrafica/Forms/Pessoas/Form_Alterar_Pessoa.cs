using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_Alterar_Pessoa : Form
    {
        private IPessoaService _pessoaService;
        private Form_TelaInicial_Pessoas _telaInicial_Pessoas;
        private readonly IServiceScopeFactory _scopeFactory;
        private Pessoa _pessoa;

        public Form_Alterar_Pessoa(Form_TelaInicial_Pessoas telaInicial_Pessoas, IServiceScopeFactory scopeFactory, Pessoa pessoa)
        {
            _telaInicial_Pessoas = telaInicial_Pessoas;
            _scopeFactory = scopeFactory;
            _pessoa = pessoa;

            InitializeComponent();
            PreencherTelaDeAlteracao();
        }

        private void PreencherTelaDeAlteracao()
        {
            textBoxNome.Text = _pessoa.Nome;
            textBoxEmail.Text = _pessoa.Email;
            maskedTextBoxCelular.Text = _pessoa.Celular;
            maskedTextBoxTelefone.Text = _pessoa.Telefone;
            if (_pessoa.TipoPessoa == TipoPessoa.FISICA)
            {
                radioButtonFisica.Checked = true;
                maskedTextBoxDocumento.Text = _pessoa.Cpf;
            }
            else
            {
                radioButtonJuridica.Checked = true;
                maskedTextBoxDocumento.Text = _pessoa.Cnpj;
            }

            textBoxNumero.Text = _pessoa.Endereco?.Numero;
            textBoxComplemento.Text = _pessoa.Endereco?.Complemento;
            textBoxEndereco.Text = _pessoa.Endereco?.Endereco;
            textBoxBairro.Text = _pessoa.Endereco?.Bairro;
            maskedTextBoxCEP.Text = _pessoa.Endereco?.Cep;
            textBoxMunicipio.Text = _pessoa.Endereco?.Municipio;
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

                    _pessoa.Alterar(pessoa);

                    var a = _pessoaService.Alterar(_pessoa);
                    this.Dispose();
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
