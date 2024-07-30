using HealthTrackingApp.DataAccess.Abstractions;
using HealthTrackingApp.DataAccess.Context;
using HealthTrackingApp.Entity.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet =_context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = GetByID(id);
            if (entity == null)
            {
                throw new Exception("Kayıt bulunamadı");
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T>? GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetByID(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
