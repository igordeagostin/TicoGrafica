using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Orcamentos;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class OrcamentoRepository : IOrcamentoRepository
    {
        private readonly TicoGraficaContext _context;

        public OrcamentoRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public Orcamento BuscarPorId(int idOrcamento)
        {
            return _context.Orcamento.FirstOrDefault(x => x.Id == idOrcamento);
        }
    }
}
