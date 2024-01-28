using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface IJobService
    {
        Task<List<Job>> GetAsync();
        Task<Job> GetAsync(int id);
        Task<Job> InsertAsync(Job newItem);
    }
    public class JobService : IJobService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public JobService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Job>> GetAsync()
        {
            return await Repo.GetAsync<Job>();
        }

        public async Task<Job> GetAsync(int id)
        {
            return await Repo.GetAsync<Job>(id);
        }

        public async Task<Job> InsertAsync(Job newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
