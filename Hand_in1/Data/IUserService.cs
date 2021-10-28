using System.Threading.Tasks;
using Hand_in1.Models;

namespace Hand_in1.Data
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
    }
}