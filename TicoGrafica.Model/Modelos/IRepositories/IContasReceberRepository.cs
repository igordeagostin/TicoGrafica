using TicoGrafica.Model.Modelos.ContasAReceber;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IContasReceberRepository
    {
        public ContasReceber BuscarPorId(int id);
    }
}
