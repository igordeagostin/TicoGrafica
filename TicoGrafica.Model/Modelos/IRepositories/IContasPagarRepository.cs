using TicoGrafica.Model.Modelos.ContasAPagar;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IContasPagarRepository
    {
        public ContasPagar BuscarPorId(int id);
    }
}
