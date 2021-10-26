using System.Collections.Generic;
using Hand_in1.Models;

namespace Hand_in1.Persistence
{
    public interface IFileJson
    {
        IList<Adult> GetAllAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        void EditAdult(Adult adult);
        Adult Get(int adultId);
    }
}