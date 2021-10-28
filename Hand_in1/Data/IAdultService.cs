using System.Collections.Generic;
using System.Threading.Tasks;
using Hand_in1.Models;

namespace Hand_in1.Data
{
    public interface IAdultService
    {
        Task CreateAsync(Adult adult);
        Task<Adult> ReadAsync(int id);
        Task<IList<Adult>> ReadAllAsync();
        Task UpdateAsync(Adult adult);
        Task DeleteAsync(int id);
    }
}