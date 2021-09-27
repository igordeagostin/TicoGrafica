using System.Collections.Generic;
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

        public Orcamento Adicionar(Orcamento orcamento)
        {
            return _orcamentoRepository.Adicionar(orcamento);
        }

        public List<Orcamento> BuscarTodos()
        {
            return _orcamentoRepository.BuscarTodos();
        }

        public void Excluir(int id)
        {
            _orcamentoRepository.Excluir(id);
        }

        public Orcamento Alterar(Orcamento orcamento)
        {
            return _orcamentoRepository.Alterar(orcamento);
        }
    }
}
