using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Services.Services.IServices;
using TicoGrafica.Model.Modelos.ContasAPagar;
using System.Collections.Generic;

namespace TicoGrafica.Services.Services
{
    public class ContasPagarService : IContasPagarService
    {
        private readonly IContasPagarRepository _contasPagarRepository;

        public ContasPagarService(IContasPagarRepository contasPagarRepository)
        {
            _contasPagarRepository = contasPagarRepository;
        }

        public ContasPagar BuscarPorId(int idContasPagar)
        {
            return _contasPagarRepository.BuscarPorId(idContasPagar);
        }

        public ContasPagar Adicionar(ContasPagar contasPagar)
        {
            return _contasPagarRepository.Adicionar(contasPagar);
        }

        public List<ContasPagar> BuscarTodos()
        {
            return _contasPagarRepository.BuscarTodos();
        }

        public void Excluir(int id)
        {
            _contasPagarRepository.Excluir(id);
        }

        public ContasPagar Alterar(ContasPagar contasPagar)
        {
            return _contasPagarRepository.Alterar(contasPagar);
        }
    }
}
