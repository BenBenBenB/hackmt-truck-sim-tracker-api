using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface IAchivementService
    {
        Task<List<Achivement>> GetAsync();
        Task<Achivement> GetAsync(int id);
        Task<Achivement> InsertAsync(Achivement newItem);
    }
    public class AchivementService : IAchivementService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public AchivementService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Achivement>> GetAsync()
        {
            return await Repo.GetAsync<Achivement>();
        }

        public async Task<Achivement> GetAsync(int id)
        {
            return await Repo.GetAsync<Achivement>(id);
        }

        public async Task<Achivement> InsertAsync(Achivement newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
