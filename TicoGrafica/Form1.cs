using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Windows.Forms;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica
{
    public partial class Form1 : Form
    {
        private readonly IPessoaService _pessoaService;

        public Form1(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var pessoa = _pessoaService.BuscarPorId(1);
        }
    }
}
