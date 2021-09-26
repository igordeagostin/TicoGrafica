using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TicoGrafica.Forms.Forms.Shared;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_Excluir_Pessoa : Form
    {
        private Form_TelaInicial_Pessoas _form_TelaInicial_Pessoas;
        private IServiceScopeFactory _scopeFactory;
        private IPessoaService _pessoaService;
        public Form_Excluir_Pessoa(IServiceScopeFactory scopeFactory, Form_TelaInicial_Pessoas form_TelaInicial_Pessoas)
        {
            _form_TelaInicial_Pessoas = form_TelaInicial_Pessoas;
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
                    _pessoaService = scope.ServiceProvider.GetRequiredService<IPessoaService>();

                    var id = _form_TelaInicial_Pessoas.RecuperarLinhaSelecionada();
                    _pessoaService.Excluir(id);
                }

                _form_TelaInicial_Pessoas.AtualizarDataGridViewPessoas();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                this.Visible = false;
                new Form_TelaDeErro("Ocorreu um erro ao excluir esta pessoa. Erro: " + ex.Message)
                    .ShowDialog();
            }
        }
    }
}
