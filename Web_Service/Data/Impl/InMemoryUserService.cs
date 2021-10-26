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
            users = new[]
            {
                new User
                {
                    Username = "Alex",
                    Password = "qwerty",
                    Domain = "via.dk",
                    BirthYear = 1992,
                    Role = "Manager",
                    SecurityLevel = 3
                },
                new User
                {
                    Username = "Bob",
                    Password = "123456",
                    Domain = "via.dk",
                    BirthYear = 1992,
                    Role = "Employee",
                    SecurityLevel = 2
                },
                new User
                {
                    Username = "Alice",
                    Password = "654321",
                    Domain = "yahoo.dk",
                    BirthYear = 2003,
                    Role = "Customer",
                    SecurityLevel = 1
                },
            }.ToList();
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
            if (first != null)
            {
                return first;
            }

            throw new Exception("User not found!");
        }
    }
}