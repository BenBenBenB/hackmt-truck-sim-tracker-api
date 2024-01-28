using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface ICargoService
    {
        Task<List<Cargo>> GetAsync();
        Task<Cargo> GetAsync(int id);
        Task<Cargo> InsertAsync(Cargo newItem);
    }
    public class CargoService : ICargoService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public CargoService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Cargo>> GetAsync()
        {
            return await Repo.GetAsync<Cargo>();
        }

        public async Task<Cargo> GetAsync(int id)
        {
            return await Repo.GetAsync<Cargo>(id);
        }

        public async Task<Cargo> InsertAsync(Cargo newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
