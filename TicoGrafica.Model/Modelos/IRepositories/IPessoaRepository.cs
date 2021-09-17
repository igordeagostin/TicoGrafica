using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IPessoaRepository
    {
        public Pessoa BuscarPorId(int idPessoa);
    }
}
