using System.Collections.Generic;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Produtos;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Services.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto Adicionar(Produto produto)
        {
            return _produtoRepository.Adicionar(produto);
        }

        public Produto Alterar(Produto produto)
        {
            return _produtoRepository.Alterar(produto);
        }

        public Produto BuscarPorId(int idProduto)
        {
            return _produtoRepository.BuscarPorId(idProduto);
        }

        public List<Produto> BuscarTodos()
        {
            return _produtoRepository.BuscarTodos();
        }

        public void Excluir(int id)
        {
            _produtoRepository.Excluir(id);
        }
    }
}
