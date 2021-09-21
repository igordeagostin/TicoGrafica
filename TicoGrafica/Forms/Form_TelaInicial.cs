using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Pessoas;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica
{
    public partial class Form_TelaInicial : Form
    {
        private readonly IPessoaService _pessoaService;
        private readonly Form_TelaInicial_Pessoas _telaInicialPessoas;

        public Form_TelaInicial(IPessoaService pessoaService, Form_TelaInicial_Pessoas telaInicialPessoas)
        {
            _pessoaService = pessoaService;
            _telaInicialPessoas = telaInicialPessoas;

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var pessoa = _pessoaService.BuscarPorId(1);
        }

        private void buttonPessoas_Click(object sender, EventArgs e)
        {
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
