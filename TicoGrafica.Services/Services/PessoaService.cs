using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Services.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Pessoa BuscarPorId(int idPessoa)
        {
            return _pessoaRepository.BuscarPorId(idPessoa);
        }
    }
}
