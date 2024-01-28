using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

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
        private ITruckSimTrackerRepository Repo  { get; set; }

        private IJobService _jobService { get; set; }
        public AchievementService(ITruckSimTrackerRepository repo, IJobService jobService)
        {
            _jobService = jobService;
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
        
        public async Task<bool> CheckCompletion(int id) 
        {
            var achivData = Repo.GetWithChildrenAsync<Achievement>(id);
            var _job = _jobService.GetAsync();
            return true; 
        }
    }

    
}
