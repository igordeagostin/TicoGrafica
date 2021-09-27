using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.Pessoas
{
    public partial class Form_TelaInicial_Pessoas : Form
    {
        private IPessoaService _pessoaService;
        private readonly IServiceScopeFactory _scopeFactory;

        public Form_TelaInicial_Pessoas(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            InitializeComponent();
        }

        private void buttonCadastrarPessoa_Click(object sender, EventArgs e)
        {
            new Form_Cadastrar_Pessoa(this, _scopeFactory).ShowDialog();
        }

        private void Form_TelaInicial_Pessoas_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewPessoas();
        }

        private void buttonAlterarPessoa_Click(object sender, EventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _pessoaService = scope.ServiceProvider.GetRequiredService<IPessoaService>();
                var pessoa = _pessoaService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_Pessoa(this, _scopeFactory, pessoa).ShowDialog();
            }
        }

        public void AtualizarDataGridViewPessoas()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _pessoaService = scope.ServiceProvider.GetRequiredService<IPessoaService>();

                var pessoas = _pessoaService
                .BuscarTodos()
                .Select(x => new PessoaDTO
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Celular = x.Celular,
                    Cpf = x.Cpf,
                    Cnpj = x.Cnpj,
                    Email = x.Email,
                    TipoPessoa = EnumHelper<TipoPessoa>.GetDisplayValue(x.TipoPessoa),
                    Telefone = x.Telefone
                })
                .ToList();

                this.dataGridViewPessoas.DataSource = pessoas;

                this.dataGridViewPessoas.Columns["Id"].HeaderText = "ID";
                this.dataGridViewPessoas.Columns["Id"].DisplayIndex = 0;
                this.dataGridViewPessoas.Columns["Id"].Visible = false;

                this.dataGridViewPessoas.Columns["Nome"].HeaderText = "NOME";
                this.dataGridViewPessoas.Columns["Nome"].DisplayIndex = 1;

                this.dataGridViewPessoas.Columns["Celular"].HeaderText = "CELULAR";
                this.dataGridViewPessoas.Columns["Celular"].DisplayIndex = 2;

                this.dataGridViewPessoas.Columns["Email"].HeaderText = "E-MAIL";
                this.dataGridViewPessoas.Columns["Email"].DisplayIndex = 3;

                this.dataGridViewPessoas.Columns["Cpf"].HeaderText = "CPF";
                this.dataGridViewPessoas.Columns["Cpf"].DisplayIndex = 4;

                this.dataGridViewPessoas.Columns["Cnpj"].HeaderText = "CNPJ";
                this.dataGridViewPessoas.Columns["Cnpj"].DisplayIndex = 5;

                this.dataGridViewPessoas.Columns["TipoPessoa"].HeaderText = "TIPO DE PESSOA";
                this.dataGridViewPessoas.Columns["TipoPessoa"].DisplayIndex = 6;

                this.dataGridViewPessoas.Columns["Telefone"].HeaderText = "TELEFONE";
                this.dataGridViewPessoas.Columns["Telefone"].DisplayIndex = 7;

                this.dataGridViewPessoas.Update();
                this.dataGridViewPessoas.Refresh();
            }
        }

        public int RecuperarLinhaSelecionada()
        {
            var linhasSelecionadas = this.dataGridViewPessoas.SelectedRows;
            if (linhasSelecionadas.Count > 0)
            {
                var idPessoa = linhasSelecionadas[0].Cells[0].Value;

                if (idPessoa != null)
                {
                    return Convert.ToInt32(idPessoa);
                }
            }
            return 0;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            new Form_Excluir_Pessoa(_scopeFactory, this).ShowDialog();
        }

        private void dataGridViewPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                _pessoaService = scope.ServiceProvider.GetRequiredService<IPessoaService>();
                var pessoa = _pessoaService.BuscarPorId(RecuperarLinhaSelecionada());
                new Form_Alterar_Pessoa(this, _scopeFactory, pessoa).ShowDialog();
            }
        }

        private void dataGridViewPessoas_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                new Form_Excluir_Pessoa(_scopeFactory, this).ShowDialog();
            }
        }
    }
}
