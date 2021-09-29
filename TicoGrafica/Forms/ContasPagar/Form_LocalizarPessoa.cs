using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicoGrafica.Forms.DTOs;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Model.Utils;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Forms.Forms.ContasPagar
{
    public partial class Form_LocalizarPessoa : Form
    {
        private IPessoaService _pessoaService;
        private readonly IServiceScopeFactory _scopeFactory;
        public Form_LocalizarPessoa(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;

            InitializeComponent();
        }

        private void Form_LocalizarPessoa_Load(object sender, EventArgs e)
        {
            AtualizarDataGridViewPessoas();
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
                this.dataGridViewPessoas.Columns["Celular"].Visible = false;

                this.dataGridViewPessoas.Columns["Email"].HeaderText = "E-MAIL";
                this.dataGridViewPessoas.Columns["Email"].DisplayIndex = 3;
                this.dataGridViewPessoas.Columns["Email"].Visible = false;

                this.dataGridViewPessoas.Columns["Cpf"].HeaderText = "CPF";
                this.dataGridViewPessoas.Columns["Cpf"].DisplayIndex = 4;

                this.dataGridViewPessoas.Columns["Cnpj"].HeaderText = "CNPJ";
                this.dataGridViewPessoas.Columns["Cnpj"].DisplayIndex = 5;

                this.dataGridViewPessoas.Columns["TipoPessoa"].HeaderText = "TIPO DE PESSOA";
                this.dataGridViewPessoas.Columns["TipoPessoa"].DisplayIndex = 6;
                this.dataGridViewPessoas.Columns["TipoPessoa"].Visible = false;

                this.dataGridViewPessoas.Columns["Telefone"].HeaderText = "TELEFONE";
                this.dataGridViewPessoas.Columns["Telefone"].DisplayIndex = 7;
                this.dataGridViewPessoas.Columns["Telefone"].Visible = false;

                this.dataGridViewPessoas.Update();
                this.dataGridViewPessoas.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
