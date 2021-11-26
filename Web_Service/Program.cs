using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Web_Service.Models;
using Web_Service.Persistence;

namespace Web_Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Seed users and adults

            using (AdultContext adultContext = new AdultContext())
            {
                if (!adultContext.Users.Any())
                {
                    SeedUsers(adultContext);
                }

                if (!adultContext.Adults.Any())
                {
                    SeedAdults(adultContext);
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        private static void SeedAdults(AdultContext adultContext)
        {
            ICollection<Adult> adults = new List<Adult>()
            {
                new()
                {
                    FirstName = "Isiah",
                    LastName = "Esparza",
                    HairColor = "Brown",
                    EyeColor = "Brown",
                    Age = 44,
                    Weight = 81,
                    Height = 172,
                    Sex = "M",

                    JobTitle = new Job()
                    {
                        JobTitle = "Call Center Agent",
                        Salary = 20308
                    }
                },
                new()
                {
                    FirstName = "Arley",
                    LastName = "Vaughn",
                    HairColor = "Black",
                    EyeColor = "Brown",
                    Age = 33,
                    Weight = 55,
                    Height = 171,
                    Sex = "M",

                    JobTitle = new Job()
                    {
                        JobTitle = "Science Teacher",
                        Salary = 55346
                    }
                },
                new()
                {
                    FirstName = "Alice",
                    LastName = "Baxter",
                    HairColor = "Black",
                    EyeColor = "Green",
                    Age = 58,
                    Weight = 62,
                    Height = 171,
                    Sex = "F",

                    JobTitle = new Job()
                    {
                        JobTitle = "Front End Developer",
                        Salary = 66408
                    }
                }
            };

            foreach (var adult in adults)
            {
                adultContext.Add(adult);
            }

            adultContext.SaveChanges();
        }

        private static void SeedUsers(AdultContext adultContext)
        {
            ICollection<User> users = new List<User>();

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

            foreach (var user in users)
            {
                adultContext.Add(user);
            }

            adultContext.SaveChanges();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}