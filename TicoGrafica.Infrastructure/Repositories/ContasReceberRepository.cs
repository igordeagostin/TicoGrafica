using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.ContasAReceber;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class ContasReceberRepository : IContasReceberRepository
    {
        private readonly TicoGraficaContext _context;

        public ContasReceberRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public ContasReceber BuscarPorId(int idContasReceber)
        {
            return _context.ContasReceber.FirstOrDefault(x => x.Id == idContasReceber);
        }
    }
}
