using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CityHall.Web.Data;
using CityHall.Web.Models;
using CityHall.Web.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
namespace CityHall.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }




        private static DateTime GetCurrentDateTimeWithCuture
        {
            get
            {
                DateTime UtCDate = DateTime.UtcNow;
                var zones = TimeZoneInfo.GetSystemTimeZones();
#if DEBUG
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
#else
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
#endif
                return TimeZoneInfo.ConvertTimeFromUtc(UtCDate, cstZone);
            }
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {

            return await _context.Set<T>().ToListAsync();
        }

        public virtual T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public virtual T GetByIdInclude(int id, params Expression<Func<T, object>>[] includes)
        {
            var entry = Include(includes).FirstOfDefaultIdEquals(id);
            return entry;
        }
        public virtual T Add(T t)
        {
            if (typeof(T).IsSubclassOf(typeof(BaseEntity)))
            {
                (t as BaseEntity).CreatedAt = DateTime.Now;
                (t as BaseEntity).UpdatedAt = DateTime.Now;
            }
            _context.Set<T>().Add(t);
            _context.SaveChanges();
            return t;
        }

        public virtual async Task<T> AddAsync(T t, bool save = true)
        {
            var CurrentCulture = new CultureInfo("it-IT");
            CultureInfo.DefaultThreadCurrentCulture = CurrentCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CurrentCulture;
            if (typeof(T).IsSubclassOf(typeof(BaseEntity)))
            {
                (t as BaseEntity).CreatedAt = DateTime.Now;
                (t as BaseEntity).UpdatedAt = DateTime.Now;
            }
            _context.Set<T>().Add(t);
            if (save)
                await _context.SaveChangesAsync();

            return t;

        }

        public virtual T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[] includeProperties)
        {
            var items = _context.Set<T>();
            IIncludableQueryable<T, object> query = null;

            if (includeProperties.Length > 0)
            {
                query = _context.Set<T>().Include(includeProperties[0]);
                for (int queryIndex = 1; queryIndex < includeProperties.Length; ++queryIndex)
                {
                    query = query.Include(includeProperties[queryIndex]);
                }
            }
            if (query != null)
            {
                var data = await query.SingleOrDefaultAsync(match);
                return data;
            }
            else
            {
                var data = await _context.Set<T>().SingleOrDefaultAsync(match);
                return data;
            }
        }
        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().Where(match).ToList();
        }



        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual async Task<int> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public virtual T Update(T t, params object[] keys)
        {
            if (t == null)
                return null;
            T exist = _context.Set<T>().Find(keys);
            if (exist != null)
            {
                if (typeof(T).IsSubclassOf(typeof(BaseEntity)))
                {
                    (t as BaseEntity).UpdatedAt = DateTime.Now;
                }
                _context.Entry(exist).CurrentValues.SetValues(t);
                _context.SaveChanges();

            }
            return exist;
        }

        public async Task<T> AddOrUpdateAsync(T entity, params object[] keys)
        {

            var t = await UpdateAsync(entity, keys);
            if (t == null)
            {
                t = await AddAsync(entity);
            }
            return t;
        }

        public virtual async Task<T> UpdateAsync(T t, params object[] keys)
        {

            var CurrentCulture = new CultureInfo("it-IT");
            CultureInfo.DefaultThreadCurrentCulture = CurrentCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CurrentCulture;
            if (t == null)
                return null;
            T exist = await _context.Set<T>().FindAsync(keys);
            if (exist != null)
            {

                if (typeof(T).IsSubclassOf(typeof(BaseEntity))
                    || typeof(BaseEntity).IsAssignableFrom(typeof(T)))
                {
                    (t as BaseEntity).UpdatedAt = DateTime.Now;
                    (t as BaseEntity).CreatedAt = (exist as BaseEntity).CreatedAt;
                }
                _context.Entry(exist).CurrentValues.SetValues(t);
                await _context.SaveChangesAsync();

            }
            return exist;
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        public virtual void Save()
        {

            _context.SaveChanges();
        }

        public async virtual Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }
        public async Task<ICollection<T>> FindAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            var items = _context.Set<T>();
            IQueryable<T> query = _context.Set<T>();

            if (includeProperties.Length > 0)
            {
                query = _context.Set<T>().Include(includeProperties[0]);

                for (int queryIndex = 1; queryIndex < includeProperties.Length; ++queryIndex)
                {
                    query = query.Include(includeProperties[queryIndex]);
                }
            }

            var data = query;
            return await data.ToListAsync();
        }
        public virtual async Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var items = _context.Set<T>();
            IQueryable<T> query = _context.Set<T>();

            if (includeProperties.Length > 0)
            {
                query = _context.Set<T>().Include(includeProperties[0]);

                for (int queryIndex = 1; queryIndex < includeProperties.Length; ++queryIndex)
                {
                    if (includeProperties[queryIndex].Body.Type == typeof(System.String))
                    {
                        var value = includeProperties[queryIndex].Body.ToString().Replace("\"", "");
                        query = query.Include(value);
                    }
                    else
                    {
                        query = query.Include(includeProperties[queryIndex]);
                    }
                }
            }
            var data = query.Where(predicate);
            return await data.ToListAsync();
        }
        public virtual async Task<ICollection<T>> FindThanIncludeByAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeProperties = null)
        {
            var items = _context.Set<T>();
            IQueryable<T> query = _context.Set<T>();

            if (includeProperties != null)
            {
                query = includeProperties(query);

            }

            var data = query.Where(predicate);
            return await data.ToListAsync();
        }

        public virtual IQueryable<T> FindThanIncludeByQueryable(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeProperties = null)
        {
            var items = _context.Set<T>();
            IQueryable<T> query = _context.Set<T>();

            if (includeProperties != null)
            {
                query = includeProperties(query);

            }

            var data = query.Where(predicate);
            return data;
        }


        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {

            IQueryable<T> queryable = GetAll();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {

                queryable = queryable.Include<T, object>(includeProperty);
            }

            return queryable;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected IQueryable<T> Include(params Expression<Func<T, object>>[] includes)
        {
            IIncludableQueryable<T, object> query = null;

            if (includes.Length > 0)
            {
                query = _context.Set<T>().Include(includes[0]);
            }
            for (int queryIndex = 1; queryIndex < includes.Length; ++queryIndex)
            {
                query = query.Include(includes[queryIndex]);
            }

            return query == null ? _context.Set<T>() : (IQueryable<T>)query;
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().CountAsync(predicate);
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AnyAsync(predicate);
        }

        public async Task TruncateAsync()
        {
            var all = await _context.Set<T>().ToListAsync();
            _context.RemoveRange(all);
        }

        public IQueryable<T> GetAllQueryable()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }


        public Task Detach(T t, Func<T, bool> equalsExpression)
        {
            _context.DetachLocal(t, equalsExpression);
            return Task.CompletedTask;
        }
        public Task<int> UpdateValueAsync(T entity, Func<T, bool> equalsExpression, params Expression<Func<T, object>>[] properties)
        {
            _context.DetachLocal(entity, equalsExpression);
            _context.Set<T>().Attach(entity);
            foreach (var property in properties)
            {
                _context.Entry(entity).Property(property).IsModified = true;
            }
            return _context.SaveChangesAsync();
        }
    }

    public static class DbContextExtention
    {
        public static TEntity FirstOfDefaultIdEquals<TEntity, TKey>(
            this IQueryable<TEntity> source, TKey otherKeyValue)
            where TEntity : class
        {
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var property = Expression.Property(parameter, "ID");
            var equal = Expression.Equal(property, Expression.Constant(otherKeyValue));
            var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, parameter);
            return source.FirstOrDefault(lambda);
        }
        public static TEntity FirstOfDefaultIdEquals<TEntity>(
            this ObservableCollection<TEntity> source, TEntity enity)
            where TEntity : class
        {
            var value = (int)enity.GetType().GetProperty("ID").GetValue(enity, null);
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var property = Expression.Property(parameter, "ID");
            var equal = Expression.Equal(property, Expression.Constant(value));
            var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, parameter);
            var queryableList = new List<TEntity>(source).AsQueryable();
            return queryableList.FirstOrDefault(lambda);
        }
        public static void DetachLocal<T>(this DbContext context, T t, Func<T, bool> predicate)
            where T : class
        {
            var local = context.Set<T>()
                .Local
                .FirstOrDefault(predicate);
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
            context.Entry(t).State = EntityState.Modified;
        }
    }

}

