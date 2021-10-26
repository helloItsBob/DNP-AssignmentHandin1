using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Web_Service.Models;

namespace Web_Service.Persistence.Impl
{
    public class FileContext : IFileJson
    {
        private IList<Adult> Adults { get; set; }

        private readonly string adultsFile = "adults.json";

        public FileContext()
        {
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            List<Adult> tmp = new List<Adult>(Adults);
            return tmp;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            SaveChanges();
            return adult;
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            Adult toRemove = Adults.First(a => a.Id == adultId);
            Adults.Remove(toRemove);
            SaveChanges(); 
        }
        
        public async Task<Adult> EditAdultAsync(Adult adult)
        {
            Adult toEdit = Adults.First(a => a.Id == adult.Id);
            if (toEdit == null)
            {
                throw new Exception($"Couldn't find an Adult with ID: {adult.Id}");
            }
            toEdit.FirstName = adult.FirstName;
            toEdit.LastName = adult.LastName;
            toEdit.HairColor = adult.HairColor;
            toEdit.EyeColor = adult.EyeColor;
            toEdit.Age = adult.Age;
            toEdit.Weight = adult.Weight;
            toEdit.Height = adult.Height;
            toEdit.Sex = adult.Sex;
            toEdit.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            toEdit.JobTitle.Salary = adult.JobTitle.Salary;
            SaveChanges();
            return toEdit;
        }
    }
}