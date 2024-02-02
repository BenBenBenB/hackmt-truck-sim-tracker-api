using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Services
{
    public interface ICargoTypeService
    {
        Task<List<CargoType>> GetAsync();
        Task<CargoType> GetAsync(int id);
        Task<CargoType> InsertAsync(CargoType newItem);
    }
    public class CargoTypeService : ICargoTypeService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public CargoTypeService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<CargoType>> GetAsync()
        {
            return await Repo.GetAsync<CargoType>();
        }

        public async Task<CargoType> GetAsync(int id)
        {
            return await Repo.GetAsync<CargoType>(id);
        }

        public async Task<CargoType> InsertAsync(CargoType newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
