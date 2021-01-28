using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entites;

        public Repository(ApplicationDbContext context)
        {
           _context = context;
            entites = context.Set<T>();
        }

        public void Add(T entity)
        {
            entites.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entites.Remove(entity);
            _context.SaveChanges();
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entites.AsEnumerable();
        }

        public IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return entites
                    .Where(predicate)
                    .AsEnumerable();
        }

        public T GetById(int id)
        {
            return entites.Find(id);
        }

        public void SaveChages()
        {
            _context.SaveChanges();
        }
    }
}
