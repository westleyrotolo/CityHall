using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
namespace CityHall.Web.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T Add(T t);
        Task<T> AddAsync(T t, bool save = true);
        int Count();
        Task<int> CountAsync();
        void Delete(T entity);
        Task<int> DeleteAsync(T entity);
        void Dispose();
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> FindAsync(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        T Get(int id);
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(int id);
        T GetByIdInclude(int id, params Expression<Func<T, object>>[] includes);
        void Save();
        Task<int> SaveChangesAsync();
        T Update(T t, params object[] keys);
        Task<T> UpdateAsync(T t, params object[] keys);
        Task<ICollection<T>> FindThanIncludeByAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeProperties = null);
        IQueryable<T> FindThanIncludeByQueryable(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeProperties = null);
        IQueryable<T> GetAllQueryable();
        Task TruncateAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> UpdateValueAsync(T entity, Func<T, bool> equalsExpression, params Expression<Func<T, object>>[] properties);
        Task<T> AddOrUpdateAsync(T entity, params object[] keys);
        Task Detach(T t, Func<T, bool> equalsExpression);

    }
}

