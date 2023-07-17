using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pazzo.Models.Repositories
{
    public class PazzoRepository<Table> : IRepository<Table> where Table : class
    {
        private pazzoEntities db = null;
        private DbSet<Table> dbTable = null;

        public PazzoRepository()
        {
            db = new pazzoEntities();
            dbTable = db.Set<Table>();
        }

        public void Create(Table _entity)
        {
            dbTable.Add(_entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            dbTable.Remove(GetByID(id));
            db.SaveChanges();
        }

        public IEnumerable<Table> GetAll()
        {
            return dbTable;
        }

        public Table GetByID(int id)
        {
            return dbTable.Find(id);
        }

        public void Update(Table _entity)
        {
            db.Entry<Table>(_entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}