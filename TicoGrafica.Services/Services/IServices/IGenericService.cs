using System.Collections.Generic;

namespace TicoGrafica.Services.Services.IServices
{
    public interface IGenericService<T>
    {
        public List<T> BuscarTodos();
        public T Adicionar(T objeto);
        public T Alterar(T objeto);
        public void Excluir(T objeto);
    }
}
