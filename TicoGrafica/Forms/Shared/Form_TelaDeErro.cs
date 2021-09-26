using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicoGrafica.Forms.Forms.Shared
{
    public partial class Form_TelaDeErro : Form
    {
        public Form_TelaDeErro(string mensagemDeErro)
        {
            InitializeComponent();
            
            this.labelErro.Text = mensagemDeErro;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
