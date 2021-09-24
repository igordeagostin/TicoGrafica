using System;
using System.Windows.Forms;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_Excluir_Pessoa : Form
    {
        private Form_TelaInicial_Pessoas _form_TelaInicial_Pessoas;
        public Form_Excluir_Pessoa(Form_TelaInicial_Pessoas form_TelaInicial_Pessoas)
        {
            _form_TelaInicial_Pessoas = form_TelaInicial_Pessoas;

            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            var id = _form_TelaInicial_Pessoas.RecuperarLinhaSelecionada();
        }
    }
}
