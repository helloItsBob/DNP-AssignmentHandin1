using System;
using System.Collections.Generic;
using System.Linq;
using Hand_in1.Models;

namespace Hand_in1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

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

        public User ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.Username.Equals(username));
            if (first == null)
            {
                throw new Exception("User not found!");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password!");
            }

            return first;
        }
    }
}