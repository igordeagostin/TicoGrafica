using System.Collections.Generic;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IPessoaService
    {
        public Pessoa BuscarPorId(int id);
        public List<Pessoa> BuscarTodos();
        public Pessoa Adicionar(Pessoa pessoa);
        public void Excluir(int id);
    }
}
