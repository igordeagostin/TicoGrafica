using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IProdutoService
    {
        public Produto BuscarPorId(int id);
    }
}
