using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Orcamentos;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Services.Services
{
    public class OrcamentoService : IOrcamentoService
    {
        private readonly IOrcamentoRepository _orcamentoRepository;

        public OrcamentoService(IOrcamentoRepository orcamentoRepository)
        {
            _orcamentoRepository = orcamentoRepository;
        }

        public Orcamento BuscarPorId(int idOrcamento)
        {
            return _orcamentoRepository.BuscarPorId(idOrcamento);
        }
    }
}
