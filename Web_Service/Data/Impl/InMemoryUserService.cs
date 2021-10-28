using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Service.Models;

namespace Web_Service.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private ICollection<User> users;

        public InMemoryUserService()
        {
            users = new List<User>();
            
            users.Add(new User
            {
                Username = "Alex",
                Password = "qwerty",
                Domain = "via.dk",
                BirthYear = 1992,
                Role = "Manager",
                SecurityLevel = 3
            });
            users.Add(new User
            {
                Username = "Bob",
                Password = "123456",
                Domain = "via.dk",
                BirthYear = 1992,
                Role = "Employee",
                SecurityLevel = 2
            });
            users.Add(new User
            {
                Username = "Alice",
                Password = "654321",
                Domain = "yahoo.dk",
                BirthYear = 2003,
                Role = "Customer",
                SecurityLevel = 1
            });
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            User user = users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (user != null)
            {
                return user;
            }

            throw new Exception("User not found!");
        }
    }
}