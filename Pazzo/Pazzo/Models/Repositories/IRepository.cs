using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazzo.Models.Repositories
{
    public interface IRepository<Table>
    {
        Task<int> CreateAsync(Table _entity);

        Task DeleteAsync(int id);

        IEnumerable<Table> GetAll();

        Task<Table> GetByIDAsync(int id);

        Task UpdateAsync(Table _entity);
    }
}