using System.Collections.Generic;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica.Services.Services
{
    public class GenericService<T> : IGenericService<T>
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public T Adicionar(T objeto)
        {
            return _genericRepository.Adicionar(objeto);
        }

        public T Alterar(T objeto)
        {
            return _genericRepository.Alterar(objeto);

        }

        public List<T> BuscarTodos()
        {
            return _genericRepository.BuscarTodos();
        }

        public void Excluir(T objeto)
        {
            _genericRepository.Excluir(objeto);
        }
    }
}
