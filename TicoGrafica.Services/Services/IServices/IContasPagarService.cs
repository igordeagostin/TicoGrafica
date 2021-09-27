using System.Collections.Generic;
using TicoGrafica.Model.Modelos.ContasAPagar;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IContasPagarService
    {
        public ContasPagar BuscarPorId(int id);
        public List<ContasPagar> BuscarTodos();
        public ContasPagar Adicionar(ContasPagar contasPagar);
        public ContasPagar Alterar(ContasPagar contasPagar);
        public void Excluir(int id);
    }
}
