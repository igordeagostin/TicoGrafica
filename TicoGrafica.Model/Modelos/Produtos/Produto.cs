using System;
using System.Collections.Generic;
using TicoGrafica.Model.Extensoes;
using TicoGrafica.Model.Modelos.Orcamentos;

namespace TicoGrafica.Model.Modelos.Produtos
{
    public class Produto : Entidade
    {
        public string Nome { get; private set; }
        public double? Valor { get; private set; }
        public ICollection<Orcamento> Orcamentos { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double? valor)
        {
            Nome = nome;
            Valor = valor;
            DataCriacao = DateTime.Now.DataTimeZoneCorreto();
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }

        public void Alterar(Produto produto)
        {
            Nome = produto.Nome;
            Valor = produto.Valor;
            DataAlteracao = DateTime.Now.DataTimeZoneCorreto();
        }
    }
}
