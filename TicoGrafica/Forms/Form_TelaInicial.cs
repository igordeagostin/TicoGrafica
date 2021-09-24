using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Pessoas;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica
{
    public partial class Form_TelaInicial : Form
    {
        private Form_TelaInicial_Pessoas _telaInicialPessoas;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_TelaInicial(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonPessoas_Click(object sender, EventArgs e)
        {
            _telaInicialPessoas = new Form_TelaInicial_Pessoas(_scopeFactory);

            _telaInicialPessoas.TopLevel = false;
            _telaInicialPessoas.AutoScroll = true;
            this.panelPrincipal.Controls.Add(_telaInicialPessoas);
            _telaInicialPessoas.FormBorderStyle = FormBorderStyle.None;
            _telaInicialPessoas.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
