using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketbooking.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task<bool> UpdateAsync(int id, T entity);
        //Task<bool> DeleteAsync(int id);
        Task<bool> AddRanges(List<T> ranges);
    }
}
