using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.ContasAPagar;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class ContasPagarRepository : IContasPagarRepository
    {
        private readonly TicoGraficaContext _context;

        public ContasPagarRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public ContasPagar BuscarPorId(int idContasPagar)
        {
            return _context.ContasPagar.FirstOrDefault(x => x.Id == idContasPagar);
        }
    }
}
