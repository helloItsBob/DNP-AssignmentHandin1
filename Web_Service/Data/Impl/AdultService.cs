using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Service.Models;
using Web_Service.Persistence;

namespace Web_Service.Data.Impl
{
    public class AdultService : IAdultService
    {
        private readonly FileContext _fileContext;
        private readonly IList<Adult> _adults;

        public AdultService(FileContext fileContext)
        {
            _fileContext = fileContext;
            _adults = fileContext.Adults;
        }
        
        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int max;
            try
            {
                max = _adults.Max(ad => ad.Id);
            }
            catch (InvalidOperationException)
            {
                max = 1;
            }
            
            adult.Id = ++max;
            _adults.Add(adult);
            _fileContext.SaveChanges();
            return adult;
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            return _adults.First(adult => adult.Id == id);
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            // return a copy
            return new List<Adult>(_adults);
        }

        public async Task<Adult> EditAdultAsync(Adult adult)
        {
            Adult toUpdate = _adults.First(ad => ad.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Sex = adult.Sex;
            toUpdate.JobTitle = toUpdate.JobTitle;
            _fileContext.SaveChanges();
            return toUpdate;
        }

        public async Task RemoveAdultAsync(int id)
        {
            Adult toDelete = _adults.First(ad => ad.Id == id);
            _adults.Remove(toDelete);
            _fileContext.SaveChanges();
        }
    }
}