using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IPessoaService
    {
        public Pessoa BuscarPorId(int idPessoa);
    }
}
