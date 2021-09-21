using System;
using System.Windows.Forms;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_TelaInicial_Pessoas : Form
    {
        private Form_Cadastrar_Pessoa _cadastrarPessoa;
        public Form_TelaInicial_Pessoas(Form_Cadastrar_Pessoa cadastrarPessoa)
        {
            _cadastrarPessoa = cadastrarPessoa;

            InitializeComponent();
        }

        private void buttonCadastrarPessoa_Click(object sender, EventArgs e)
        {
           // CadastrarPessoa cadastrarPessoa = new CadastrarPessoa();
            _cadastrarPessoa.Show();
        }
    }
}
