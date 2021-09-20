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

        public Produto BuscarPorId(int idProduto)
        {
            return _produtoRepository.BuscarPorId(idProduto);
        }
    }
}
