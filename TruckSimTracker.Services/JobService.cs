using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface IAchievementService
    {
        Task<List<Achivement>> GetAsync();
        Task<Achivement> GetAsync(int id);
        Task<Achivement> InsertAsync(Achivement newItem);
    }
    public class AchievementService : IAchievementService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public AchievementService(ITruckSimTrackerRepository repo)
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
