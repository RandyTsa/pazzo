using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazzo.Models.Repositories
{
    public interface IRepository<Table>
    {
        void Create(Table _entity);

        void Delete(int id);

        IEnumerable<Table> GetAll();

        Table GetByID(int id);

        void Update(Table _entity);
    }
}