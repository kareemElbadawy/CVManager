using CVManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVManager.Core.Repositories
{
    namespace CVManager.Domain.Repositories
    {
        public interface ICVRepository
        {
            Task<IEnumerable<CV>> GetAllAsync();
            Task<CV> GetByIdAsync(int id);
            Task AddAsync(CV cv);
            Task UpdateAsync(CV cv);
            Task DeleteAsync(int id);
        }
    }

}
