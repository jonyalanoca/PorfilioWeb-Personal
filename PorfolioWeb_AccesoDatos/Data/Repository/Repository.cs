using PorfolioWeb_AccesoDatos.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioWeb_AccesoDatos.Data.Repository
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        internal DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet=context.Set<T>();
        }
        public void Add(T entity)
        {
           _dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
            //si nos mandan un numero ej: 0 devolvera un null gracias entity
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includePropertyes = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
                _dbSet.Where(filter); //where sirve para realizar una consulta filtrada y requiere una expresion lamba
            }

            //Include properties separado por comas
            if (includePropertyes != null)
            {
                    foreach(var includeProperty in includePropertyes.Split(',',StringSplitOptions.RemoveEmptyEntries))//para los items vacios en la "lista"
                    {
                        query = query.Include(includeProperty);//incluya las tablas relacionadas(1a1,1a+)
                    }
            }
            if (orderBy != null)// validar el ordenamiento
            {
                return orderBy(query).ToList();
            }
            return query.ToList();//retorna lista de los registros
        }

        public T GetFirstOrderDefault(Expression<Func<T, bool>> filter = null, string includePropertyes = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //Include properties separado por comas
            if (includePropertyes != null)
            {
                foreach (var includeProperty in includePropertyes.Split(',', StringSplitOptions.RemoveEmptyEntries))//para los items vacios en la "lista"
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();//traemos solo un registro que cumpla con la consulta
        }

        public void Remove(int id)
        {
            T entityToRemove = _dbSet.Find(id);
            //_dbSet.Remove(entityToRemove);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
