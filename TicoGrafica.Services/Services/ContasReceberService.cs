using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Services.Services.IServices;
using TicoGrafica.Model.Modelos.ContasAReceber;

namespace TicoGrafica.Services.Services
{
    public class ContasReceberService : IContasReceberService
    {
        private readonly IContasReceberRepository _contasReceberRepository;

        public ContasReceberService(IContasReceberRepository contasReceberRepository)
        {
            _contasReceberRepository = contasReceberRepository;
        }

        public ContasReceber BuscarPorId(int idContasReceber)
        {
            return _contasReceberRepository.BuscarPorId(idContasReceber);
        }
    }
}
