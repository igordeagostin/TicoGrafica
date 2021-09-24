using System;
using System.Collections.Generic;
using TicoGrafica.Model.Extensoes;
using TicoGrafica.Model.Modelos.ContasAPagar;
using TicoGrafica.Model.Modelos.ContasAReceber;
using TicoGrafica.Model.Modelos.Orcamentos;
using TicoGrafica.Model.Utils;

namespace TicoGrafica.Model.Modelos.Pessoas
{
    public class Pessoa : Entidade
    {
        public string Nome { get; private set; }
        public string Celular { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }
        public string Cpf { get; private set; }
        public string Cnpj { get; private set; }
        public EnderecoPessoa Endereco { get; private set; }
        public ICollection<Orcamento> Orcamentos { get; set; }
        public ICollection<ContasReceber> ContasAReceber { get; set; }
        public ICollection<ContasPagar> ContasAPagar { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(string nome, string celular, string telefone, string email, TipoPessoa tipoPessoa, string cpf, string cnpj, EnderecoPessoa endereco)
        {
            Nome = nome;
            Celular = celular;
            Telefone = telefone;
            Email = email;
            TipoPessoa = tipoPessoa;
            Endereco = endereco;
            DataCriacao = DateTime.Now.DataTimeZoneCorreto();
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();

            if (tipoPessoa == TipoPessoa.FISICA)
            {
                Cpf = cpf;
            }
            else if (tipoPessoa == TipoPessoa.JURIDICA)
            {
                Cnpj = cnpj;
            }

            EstaValido();
        }

        public void Alterar(Pessoa pessoa)
        {
            Nome = pessoa.Nome;
            Telefone = pessoa.Telefone;
            Email = pessoa.Email;
            TipoPessoa = pessoa.TipoPessoa;
            Endereco = pessoa.Endereco;
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();

            if (pessoa.TipoPessoa == TipoPessoa.FISICA)
            {
                Cpf = pessoa.Cpf;
            }
            else if (pessoa.TipoPessoa == TipoPessoa.JURIDICA)
            {
                Cnpj = pessoa.Cnpj;
            }

            EstaValido();
        }

        public void EstaValido()
        {
            if (string.IsNullOrEmpty(this.Nome) || string.IsNullOrEmpty(this.Telefone))
            {
                throw new ArgumentNullException("Nome ou telefone estão em branco.");
            }

            if (!string.IsNullOrEmpty(this.Cpf))
            {
                Validador.CpfValido(this.Cpf);
            }

            if (!string.IsNullOrEmpty(this.Cnpj))
            {
                Validador.CnpjValido(this.Cnpj);
            }

            if (!string.IsNullOrEmpty(this.Email))
            {
                Validador.EmailValido(this.Email);
            }
        }
    }
}
