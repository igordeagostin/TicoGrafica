using System;
using System.Windows.Forms;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_Cadastrar_Pessoa : Form
    {
        private readonly IPessoaService _pessoaService;

        public Form_Cadastrar_Pessoa(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(textBoxNome.Text, textBoxTelefone.Text, textBoxEmail.Text,
                (radioButtonFisica.Checked ? TipoPessoa.FISICA : TipoPessoa.JURIDICA), textBoxDocumento.Text,
                textBoxDocumento.Text, new EnderecoPessoa(textBoxEndereco.Text, textBoxNumero.Text, textBoxNumero.Text,
                textBoxComplemento.Text, textBoxMunicipio.Text, textBoxCEP.Text));

            _pessoaService.Adicionar(pessoa);

            var a = _pessoaService.BuscarTodos();
        }
    }
}
