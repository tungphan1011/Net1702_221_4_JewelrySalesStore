using JewelrySalesStoreData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelrySalesStoreData.Base
{
    public class BaseDAO<T> where T : class
    {
        protected readonly NET1702_PRN221_JewelrySalesStoreContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseDAO()
        {
            _context = new NET1702_PRN221_JewelrySalesStoreContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public bool Remove(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            return true;
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T GetById(string code)
        {
            return _dbSet.Find(code);
        }
    }
}
