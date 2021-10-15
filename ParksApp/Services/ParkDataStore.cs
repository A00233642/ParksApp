using ParksApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParksApp.Services
{
    public class ParkDataStore : IParkDataStore<Park>
    {
        private List<Park> parks;

        async Task Init()
        {
            await Task.Delay(100);
        }

        public async Task<IEnumerable<Park>> GetParks()
        {

            await Init();

             parks = new List<Park>
            {

            new Park { Id = 1, Name = "Park A", Description = "This is Park a."},
            new Park { Id = 2, Name = "Park B", Description = "This is Park b."},
            new Park { Id = 3, Name = "Park C", Description = "This is Park c."},
            new Park { Id = 4, Name = "Park D", Description = "This is Park d."}

            };

            return parks;
        }

        public async Task<Park> GetPark(int parkId)
        {
            await Init();

            return parks.Find(park => park.Id == parkId);
        }
    }
}