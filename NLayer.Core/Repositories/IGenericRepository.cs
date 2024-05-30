using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task AddAsync();
        Task AddRangeAync(IEnumerable<T> entities);

        IQueryable<T> Where(Expression<Func<T,bool>> expression); //IQueryable => Normalde çağrılar DB'ye gitmez. ToList()/ToListAsync() gibi metodlar çağrıldığında gider(performans için).
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T,bool>> expression); //IQueryable => Normalde çağrılar DB'ye gitmez. ToList()/ToListAsync() gibi metodlar çağrıldığında gider(performans için).
        // Örn: productRepository.where(x => x.Id > 5).orderby(x => x.Id).ToListAsync(); // Önce where ve orderby çalışır.

        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
