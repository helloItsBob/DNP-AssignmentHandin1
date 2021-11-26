using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_Service.Models;
using Web_Service.Persistence;

namespace Web_Service.Data.Impl
{
    public class SqliteUserService : IUserService
    {
        private AdultContext _adultContext;

        public SqliteUserService(AdultContext todoContext)
        {
            _adultContext = todoContext;
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User user = await _adultContext.Users.FirstOrDefaultAsync(u =>
                u.Username.Equals(username));
            if (user == null)
            {
                throw new Exception("User not found!");
            }
            
            if (user != null && !user.Password.Equals(password))
            {
                throw new Exception("Password not correct");
            }

            return user;
        }
    }
}