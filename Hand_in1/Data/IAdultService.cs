using System.Collections.Generic;
using System.Threading.Tasks;
using Hand_in1.Models;

namespace Hand_in1.Data
{
    public interface IAdultService
    {
        Task AddAdultAsync(Adult adult);
        Task<Adult> GetAdultAsync(int id);
        Task<IList<Adult>> GetAllAdultsAsync();
        Task EditAdultAsync(Adult adult);
        Task RemoveAdultAsync(int id);
    }
}