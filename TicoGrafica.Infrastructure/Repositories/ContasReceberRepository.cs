using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.ContasAReceber;
using System;
using System.Collections.Generic;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class ContasReceberRepository : IContasReceberRepository
    {
        private readonly TicoGraficaContext _context;

        public ContasReceberRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public ContasReceber BuscarPorId(int idContasReceber)
        {
            return _context.ContasReceber
                .FirstOrDefault(x => x.Id == idContasReceber);
        }

        public ContasReceber Adicionar(ContasReceber objeto)
        {
            _context.Add(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public List<ContasReceber> BuscarTodos()
        {
            return _context.ContasReceber.ToList();
        }

        public void Excluir(int id)
        {
            try
            {
                var contasReceber = _context.ContasReceber.FirstOrDefault(x => x.Id == id);
                _context.ContasReceber.Remove(contasReceber);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ContasReceber Alterar(ContasReceber contasReceber)
        {
            try
            {
                _context.ContasReceber.Update(contasReceber);
                _context.SaveChanges();
                return contasReceber;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
