using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Hand_in1.Models;

namespace Hand_in1.Persistence.Impl
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

        public IList<Adult> GetAllAdults()
        {
            List<Adult> tmp = new List<Adult>(Adults);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            Adult toRemove = Adults.First(a => a.Id == adultId);
            Adults.Remove(toRemove);
            SaveChanges(); 
        }
        
        public void EditAdult(Adult adult)
        {
            Adult toEdit = Adults.First(a => a.Id == adult.Id);
            
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
        }

        public Adult Get(int adultId)
        {
            return Adults.FirstOrDefault(a => a.Id == adultId);
        }
    }
}