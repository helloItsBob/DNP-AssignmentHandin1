using System.Collections.Generic;
using System.Threading.Tasks;
using Web_Service.Models;

namespace Web_Service.Data
{
    public interface IAdultService
    {
        Task<Adult> CreateAsync(Adult adult);
        Task<Adult> ReadAsync(int id);
        Task<IList<Adult>> ReadAllAsync();
        Task<Adult> UpdateAsync(Adult adult);
        Task DeleteAsync(int id);
    }
}