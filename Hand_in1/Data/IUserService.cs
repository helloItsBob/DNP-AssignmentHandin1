using Hand_in1.Models;

namespace Hand_in1.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}