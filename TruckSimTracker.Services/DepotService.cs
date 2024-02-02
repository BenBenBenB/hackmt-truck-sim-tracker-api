using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Services
{
    public interface IDepotService
    {
        Task<List<Depot>> GetAsync();
        Task<Depot> GetAsync(int id);
        Task<Depot> InsertAsync(Depot newItem);
    }
    public class DepotService : IDepotService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public DepotService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Depot>> GetAsync()
        {
            return await Repo.GetAsync<Depot>();
        }

        public async Task<Depot> GetAsync(int id)
        {
            return await Repo.GetAsync<Depot>(id);
        }

        public async Task<Depot> InsertAsync(Depot newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
