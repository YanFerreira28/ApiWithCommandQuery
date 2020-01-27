using DDDCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDCQRS.Domain.Contracts
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAll();

        Task<Produto> Get(int id);

        Task<Produto> Buscar(Expression<Func<Produto, bool>> expression);

        Task Insert(Produto obj);

        void Update(Produto obj);

        Task Delete(int id);

        void Dispose();

        Task Save();
    }
}
