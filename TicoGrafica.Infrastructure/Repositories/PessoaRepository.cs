using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly TicoGraficaContext _context;

        public PessoaRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public Pessoa BuscarPorId(int idPessoa)
        {
            return _context.Pessoas.FirstOrDefault(x => x.Id == idPessoa);
        }
    }
}
