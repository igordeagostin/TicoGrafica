﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Shared;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasPagar
{
    public partial class Form_Excluir_ContasPagar : Form
    {
        private Form_TelaInicial_ContasPagar _form_TelaInicial;
        private IServiceScopeFactory _scopeFactory;
        private IContasPagarService _contasPagarService;
        public Form_Excluir_ContasPagar(IServiceScopeFactory scopeFactory, Form_TelaInicial_ContasPagar form_TelaInicial)
        {
            _form_TelaInicial = form_TelaInicial;
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    _contasPagarService = scope.ServiceProvider.GetRequiredService<IContasPagarService>();

                    var id = _form_TelaInicial.RecuperarLinhaSelecionada();
                    _contasPagarService.Excluir(id);
                }

                _form_TelaInicial.AtualizarDataGridViewProdutos();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                this.Visible = false;
                new Form_TelaDeErro("Ocorreu um erro ao excluir esta conta a pagar. Erro: " + ex.Message)
                    .ShowDialog();
            }
        }
    }
}
