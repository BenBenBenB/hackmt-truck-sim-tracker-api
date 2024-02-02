using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;
using TruckSimTracker.Services.Dto;

namespace TruckSimTracker.Services
{
    public interface IJobService
    {
        Task<List<JobDto>> GetAsync();
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

        public async Task<List<JobDto>> GetAsync()
        {
            var data = await Repo.GetAsync<Job>();
            return data.Select(job => new JobDto()
            {
                Id = job.Id,
                CargoName = "CargoToDo",
                DepotFromName = "ToName",
                DepotFromLocation = "Todo, TD",
                DepotToName = "FromName",
                DepotToLocation = "Todo, TD",
                Paid = job.Pay,
                Exp = job.Exp,
                Perfect = job.Perfect,
            }).ToList();
        }

        public async Task<Job> GetAsync(int id)
        {
            return await Repo.GetAsync<Job>(id);
        }

        public async Task<Job> InsertAsync(Job newItem)
        {
            var result = await Repo.InsertAsync(newItem);
            return result;
        }
    }
}
