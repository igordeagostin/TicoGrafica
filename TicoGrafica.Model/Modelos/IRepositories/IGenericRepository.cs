using System.Collections.Generic;

namespace TicoGrafica.Model.Modelos.IRepositories
{
    public interface IGenericRepository<T>
    {
        public List<T> BuscarTodos();
        public T Adicionar(T objeto);
        public T Alterar(T objeto);
        public void Excluir(T objeto);
    }
}
