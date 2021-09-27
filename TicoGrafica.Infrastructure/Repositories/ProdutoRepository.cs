using System;
using System.Collections.Generic;
using System.Linq;
using TicoGrafica.Model.Modelos.IRepositories;
using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly TicoGraficaContext _context;

        public ProdutoRepository(TicoGraficaContext context)
        {
            _context = context;
        }

        public Produto BuscarPorId(int idProduto)
        {
            return _context.Produto
                .FirstOrDefault(x => x.Id == idProduto);
        }

        public Produto Adicionar(Produto objeto)
        {
            _context.Add(objeto);
            _context.SaveChanges();
            return objeto;
        }

        public List<Produto> BuscarTodos()
        {
            return _context.Produto.ToList();
        }

        public void Excluir(int id)
        {
            try
            {
                var produto = _context.Produto.FirstOrDefault(x => x.Id == id);
                _context.Produto.Remove(produto);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produto Alterar(Produto produto)
        {
            try
            {
                _context.Produto.Update(produto);
                _context.SaveChanges();
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
