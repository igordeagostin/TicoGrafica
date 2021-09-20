using System.Collections.Generic;
using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TicoGraficaContext _context;

        public GenericRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public T Adicionar(T objeto)
        {
            _context.Add(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public T Alterar(T objeto)
        {
            _context.Update(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public List<T> BuscarTodos()
        {
            return _context.Set<T>().ToList();
        }

        public void Excluir(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }
    }
}
