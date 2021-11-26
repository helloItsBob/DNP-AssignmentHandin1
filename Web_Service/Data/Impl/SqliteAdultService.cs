using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Web_Service.Models;
using Web_Service.Persistence;

namespace Web_Service.Data.Impl
{
    public class SqliteAdultService : IAdultService
    {
        private AdultContext _adultContext;

        public SqliteAdultService(AdultContext adultContext)
        {
            _adultContext = adultContext;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            EntityEntry<Adult> newlyAddedAdult = await _adultContext.AddAsync(adult);
            await _adultContext.SaveChangesAsync();
            return newlyAddedAdult.Entity;
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            return await _adultContext.Adults.Include(adult => adult.JobTitle).
                FirstAsync(adult => adult.Id == id);
        }

        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            return await _adultContext.Adults
                .Include(adult => adult.JobTitle)
                .ToListAsync();
        }

        public async Task<Adult> EditAdultAsync(Adult adult)
        {
            try
            {
                _adultContext.Update(adult);
                await _adultContext.SaveChangesAsync();
                MrProperCleanProper();
                return adult;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find Adult with an id{adult.Id}");
            }
        }

        public async Task RemoveAdultAsync(int id)
        {
            Adult toDelete = await _adultContext.Adults.FirstOrDefaultAsync(a => a.Id == id);

            if (toDelete != null)
            {
                _adultContext.Adults.Remove(toDelete);
                await _adultContext.SaveChangesAsync();
                MrProperCleanProper();
            }
        }

        // method to clean the jobs from the table when updating and deleting
        public async void MrProperCleanProper()
        {
            foreach (Job job in _adultContext.Jobs)
            {
                if (!_adultContext.Adults.Any(a => a.JobTitle.Id == job.Id))
                {
                    _adultContext.Jobs.Remove(job);
                }
            }

            await _adultContext.SaveChangesAsync();
        }
    }
}