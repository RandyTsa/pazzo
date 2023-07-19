using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Pazzo.Models.Repositories
{
    public class PazzoRepository<Table> : IRepository<Table> where Table : class
    {
        private pazzoEntities db = null;
        private DbSet<Table> dbTable = null;
        private pazzoEntities pazzoEntities;

        public PazzoRepository()
        {
            db = new pazzoEntities();
            dbTable = db.Set<Table>();
        }

        public PazzoRepository(pazzoEntities pazzoEntities)
        {
            this.pazzoEntities = pazzoEntities;
        }

        public async Task<int> CreateAsync(Table _entity)
        {
            dbTable.Add(_entity);
            return await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            dbTable.Remove(await GetByIDAsync(id));
            await db.SaveChangesAsync();
        }

        public IEnumerable<Table> GetAll()
        {
            return dbTable;
        }

        public async Task<Table> GetByIDAsync(int id)
        {
            return await dbTable.FindAsync(id);
        }

        public async Task UpdateAsync(Table _entity)
        {
            db.Entry<Table>(_entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}