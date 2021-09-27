using System.Collections.Generic;
using TicoGrafica.Model.Modelos.Orcamentos;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IOrcamentoService
    {
        public Orcamento BuscarPorId(int id);
        public List<Orcamento> BuscarTodos();
        public Orcamento Adicionar(Orcamento orcamento);
        public Orcamento Alterar(Orcamento orcamento);
        public void Excluir(int id);
    }
}
