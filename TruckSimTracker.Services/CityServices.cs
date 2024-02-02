using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAsync();
        Task<City> GetAsync(int id);
        Task<City> InsertAsync(City newItem);
    }
    public class CityService : ICityService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public CityService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<City>> GetAsync()
        {
            return await Repo.GetAsync<City>();
        }

        public async Task<City> GetAsync(int id)
        {
            return await Repo.GetAsync<City>(id);
        }

        public async Task<City> InsertAsync(City newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
