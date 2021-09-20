using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly TicoGraficaContext _context;

        public ProdutoRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public Produto BuscarPorId(int idProduto)
        {
            return _context.Produto.FirstOrDefault(x => x.Id == idProduto);
        }
    }
}
