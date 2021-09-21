using System.Collections.Generic;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IPessoaRepository
    {
        public Pessoa BuscarPorId(int id);
        public List<Pessoa> BuscarTodos();
        public Pessoa Adicionar(Pessoa pessoa);
    }
}
