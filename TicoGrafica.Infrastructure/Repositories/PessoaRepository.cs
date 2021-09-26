using System;
using System.Collections.Generic;
using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Pessoas;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly TicoGraficaContext _context;

        public PessoaRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public Pessoa BuscarPorId(int idPessoa)
        {
            return _context.Pessoas.FirstOrDefault(x => x.Id == idPessoa);
        }

        public Pessoa Adicionar(Pessoa objeto)
        {
            _context.Add(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public List<Pessoa> BuscarTodos()
        {
            return _context.Pessoas.ToList();
        }

        public void Excluir(int id)
        {
            try
            {
                var pessoa = _context.Pessoas.FirstOrDefault(x => x.Id == id);
                _context.Pessoas.Remove(pessoa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
