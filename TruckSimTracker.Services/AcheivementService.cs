using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface IAchievementService
    {
        Task<List<Achievement>> GetAsync();
        Task<Achievement> GetAsync(int id);
        Task<Achievement> InsertAsync(Achievement newItem);
    }
    public class AchievementService : IAchievementService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public AchievementService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Achievement>> GetAsync()
        {
            return await Repo.GetAsync<Achievement>();
        }

        public async Task<Achievement> GetAsync(int id)
        {
            return await Repo.GetAsync<Achievement>(id);
        }

        public async Task<Achievement> InsertAsync(Achievement newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
