using System;
using System.Collections.Generic;
using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Orcamentos;
using Microsoft.EntityFrameworkCore;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class OrcamentoRepository : IOrcamentoRepository
    {
        private readonly TicoGraficaContext _context;

        public OrcamentoRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public Orcamento BuscarPorId(int idOrcamento)
        {
            return _context.Orcamento
                .Include(x => x.Produto)
                .Include(x => x.Pessoa)
                .FirstOrDefault(x => x.Id == idOrcamento);
        }

        public Orcamento Adicionar(Orcamento objeto)
        {
            _context.Add(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public List<Orcamento> BuscarTodos()
        {
            return _context.Orcamento
                .Include(x => x.Produto)
                .Include(x => x.Pessoa)
                .ToList();
        }

        public void Excluir(int id)
        {
            try
            {
                var orcamento = _context.Orcamento.FirstOrDefault(x => x.Id == id);
                _context.Orcamento.Remove(orcamento);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Orcamento Alterar(Orcamento orcamento)
        {
            try
            {
                _context.Orcamento.Update(orcamento);
                _context.SaveChanges();
                return orcamento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
