using System.Collections.Generic;
using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IProdutoRepository
    {
        public Produto BuscarPorId(int id);
        public List<Produto> BuscarTodos();
        public Produto Adicionar(Produto produto);
        public Produto Alterar(Produto produto);
        public void Excluir(int id);
    }
}
