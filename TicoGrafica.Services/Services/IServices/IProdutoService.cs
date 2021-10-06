using System.Collections.Generic;
using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IProdutoService
    {
        public Produto BuscarPorId(int id);
        public List<Produto> BuscarTodos();
        List<Produto> BuscarPorNome(string texto);
        public Produto Adicionar(Produto produto);
        public Produto Alterar(Produto produto);
        public void Excluir(int id);
    }
}
