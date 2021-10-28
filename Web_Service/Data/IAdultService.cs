using System.Collections.Generic;
using System.Threading.Tasks;
using Web_Service.Models;

namespace Web_Service.Data
{
    public interface IAdultService
    {
        Task<Adult> AddAdultAsync(Adult adult);
        Task<Adult> GetAdultAsync(int id);
        Task<IList<Adult>> GetAllAdultsAsync();
        Task<Adult> EditAdultAsync(Adult adult);
        Task RemoveAdultAsync(int id);
    }
}