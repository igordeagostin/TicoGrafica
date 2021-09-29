using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.ContasPagar;
using TicoGrafica.Forms.Forms.Pessoas;
using TicoGrafica.Forms.Forms.Produtos;

namespace TicoGrafica
{
    public partial class Form_TelaInicial : Form
    {
        private Form_TelaInicial_Pessoas _telaInicialPessoas;
        private Form_TelaInicial_Produtos _telaInicialProdutos;
        private Form_TelaInicial_ContasPagar _telaInicialContasPagar;
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

        private void button2_Click(object sender, EventArgs e)
        {
            _telaInicialProdutos = new Form_TelaInicial_Produtos(_scopeFactory);

            _telaInicialProdutos.TopLevel = false;
            _telaInicialProdutos.AutoScroll = true;
            this.panelPrincipal.Controls.Add(_telaInicialProdutos);
            _telaInicialProdutos.FormBorderStyle = FormBorderStyle.None;
            _telaInicialProdutos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _telaInicialContasPagar = new Form_TelaInicial_ContasPagar(_scopeFactory);

            _telaInicialContasPagar.TopLevel = false;
            _telaInicialContasPagar.AutoScroll = true;
            this.panelPrincipal.Controls.Add(_telaInicialContasPagar);
            _telaInicialContasPagar.FormBorderStyle = FormBorderStyle.None;
            _telaInicialContasPagar.Show();
        }
    }
}
