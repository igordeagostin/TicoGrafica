using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IProdutoRepository
    {
        public Produto BuscarPorId(int id);
    }
}
