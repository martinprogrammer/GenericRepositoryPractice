using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepositoryPractice.Models
{
    public class GenericAbstract<T, Context> : IGenericRepository<T> where T : class where Context : DbContext, new()
    {
      

        private Context _context = new Context();

        public Context TheContext
        {
            get { return _context; }
            set { _context = value; }
        }


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).SingleOrDefault();
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}