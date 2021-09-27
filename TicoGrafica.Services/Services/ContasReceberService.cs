using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Services.Services.IServices;
using TicoGrafica.Model.Modelos.ContasAReceber;
using System.Collections.Generic;

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

        public ContasReceber Adicionar(ContasReceber contasReceber)
        {
            return _contasReceberRepository.Adicionar(contasReceber);
        }

        public List<ContasReceber> BuscarTodos()
        {
            return _contasReceberRepository.BuscarTodos();
        }

        public void Excluir(int id)
        {
            _contasReceberRepository.Excluir(id);
        }

        public ContasReceber Alterar(ContasReceber contasReceber)
        {
            return _contasReceberRepository.Alterar(contasReceber);
        }
    }
}
