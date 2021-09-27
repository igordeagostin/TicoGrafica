using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.ContasAPagar;
using System;
using System.Collections.Generic;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class ContasPagarRepository : IContasPagarRepository
    {
        private readonly TicoGraficaContext _context;

        public ContasPagarRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public ContasPagar BuscarPorId(int idContasPagar)
        {
            return _context.ContasPagar
                .FirstOrDefault(x => x.Id == idContasPagar);
        }

        public ContasPagar Adicionar(ContasPagar objeto)
        {
            _context.Add(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public List<ContasPagar> BuscarTodos()
        {
            return _context.ContasPagar.ToList();
        }

        public void Excluir(int id)
        {
            try
            {
                var contasPagar = _context.ContasPagar.FirstOrDefault(x => x.Id == id);
                _context.ContasPagar.Remove(contasPagar);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ContasPagar Alterar(ContasPagar contasPagar)
        {
            try
            {
                _context.ContasPagar.Update(contasPagar);
                _context.SaveChanges();
                return contasPagar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
