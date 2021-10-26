using System.Collections.Generic;
using System.Threading.Tasks;
using Web_Service.Models;

namespace Web_Service.Persistence
{
    public interface IFileJson
    {
        Task<IList<Adult>> GetAllAdultsAsync();
        Task<Adult> AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task<Adult> EditAdultAsync(Adult adult);
    }
}