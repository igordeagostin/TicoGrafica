﻿using System.Collections.Generic;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IPessoaRepository
    {
        public Pessoa BuscarPorId(int id);
        public List<Pessoa> BuscarTodos();
        public List<Pessoa> BuscarPorNomeOuDocumento(string texto);
        public Pessoa Adicionar(Pessoa pessoa);
        public Pessoa Alterar(Pessoa pessoa);
        public void Excluir(int id);
    }
}
