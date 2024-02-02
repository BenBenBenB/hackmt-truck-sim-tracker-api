using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace TruckSimTracker.Services
{
    public interface IAchievementService
    {
        Task<List<Achievement>> GetAsync();
        Task<Achievement> GetAsync(int achievementId);
        Task<Achievement> GetWithChildrenAsync(int achievementId);
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
            return await Repo.GetWithChildrenAsync<Achievement>(id);
        }

        public async Task<Achievement> InsertAsync(Achievement newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
        
        public async Task<bool> GetCompletionAsync(int achievementId) 
        {
            var achieveData = await GetWithChildrenAsync(achievementId);
            var jobs = await _jobService.GetAsync();
            //return BusinessLogic.RequirementHelper.CalculateCompletion(achieveData, jobs); 
            return true;
        }

        public async Task<Achievement> GetWithChildrenAsync(int id)
        {
            return await Repo.GetWithChildrenAsync<Achievement>(id);
        }
    }

    
}
