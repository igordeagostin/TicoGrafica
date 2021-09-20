using TicoGrafica.Model.Modelos.ContasAPagar;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IContasPagarService
    {
        public ContasPagar BuscarPorId(int id);
    }
}
