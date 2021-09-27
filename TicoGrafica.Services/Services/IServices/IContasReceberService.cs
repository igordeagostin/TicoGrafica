using System.Collections.Generic;
using TicoGrafica.Model.Modelos.ContasAReceber;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IContasReceberService
    {
        public ContasReceber BuscarPorId(int id);
        public List<ContasReceber> BuscarTodos();
        public ContasReceber Adicionar(ContasReceber contasReceber);
        public ContasReceber Alterar(ContasReceber contasReceber);
        public void Excluir(int id);
    }
}
