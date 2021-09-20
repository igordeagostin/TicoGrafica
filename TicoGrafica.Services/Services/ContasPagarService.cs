using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Services.Services.IServices;
using TicoGrafica.Model.Modelos.ContasAPagar;

namespace TicoGrafica.Services.Services
{
    public class ContasPagarService : IContasPagarService
    {
        private readonly IContasPagarRepository _contasPagarRepository;

        public ContasPagarService(IContasPagarRepository contasPagarRepository)
        {
            _contasPagarRepository = contasPagarRepository;
        }

        public ContasPagar BuscarPorId(int idContasPagar)
        {
            return _contasPagarRepository.BuscarPorId(idContasPagar);
        }
    }
}
