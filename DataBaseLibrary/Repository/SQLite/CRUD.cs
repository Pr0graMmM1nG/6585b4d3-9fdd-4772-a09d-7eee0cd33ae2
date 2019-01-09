using DataBaseLibrary.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary.Repository.SQLite
{
    class CRUD
    {
        private readonly PriceListContext _context;
        public CRUD()
        {
            _context = new PriceListContext();

        }
        public T GetById<T>(int idParam) where T : class
        {

            var entry = _context.Set<T>().Find(idParam);
            return entry;
        }
        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Add<T>(T entry) where T : class
        {
            _context.Set<T>().Add(entry);
        }

        public void Remove<T>(T entry) where T : class
        {
            _context.Entry(entry).State = EntityState.Deleted;
        }

        public void Update<T>(T entry) where T : class
        {
            _context.Entry(entry).State = EntityState.Modified;
        }


        public void Save()
        {
            _context.SaveChanges();

        }
    }
}
