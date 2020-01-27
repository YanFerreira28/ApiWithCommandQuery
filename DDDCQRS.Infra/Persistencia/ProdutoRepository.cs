using DDDCQRS.Domain.Contracts;
using DDDCQRS.Domain.Entities;
using DDDCQRS.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDCQRS.Infra.Persistencia
{
    public class ProdutoRepository : IProdutoRepository
    {
        public DataContext _context;

        public ProdutoRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<Produto> Buscar(Expression<Func<Produto, bool>> expression)
        {
            return await _context.Set<Produto>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task Delete(int id)
        {
            var obj = await _context.Set<Produto>().FindAsync(id);
            _context.Set<Produto>().Remove(obj);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<Produto> Get(int id)
        {
            return await _context.Set<Produto>().FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _context.Set<Produto>().ToListAsync();
        }

        public async Task Insert(Produto obj)
        {
            await _context.Set<Produto>().AddAsync(obj);

        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Produto obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
