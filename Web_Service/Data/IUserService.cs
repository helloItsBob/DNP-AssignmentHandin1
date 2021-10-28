using System.Threading.Tasks;
using Web_Service.Models;

namespace Web_Service.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string username, string password);
    }
}