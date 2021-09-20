using TicoGrafica.Model.Modelos.Orcamentos;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IOrcamentoRepository
    {
        public Orcamento BuscarPorId(int id);
    }
}
