using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Services
{
    public interface IStateService
    {
        Task<List<State>> GetAsync();
        Task<State> GetAsync(int id);
        Task<State> InsertAsync(State newItem);
    }
    public class StateService : IStateService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public StateService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<State>> GetAsync()
        {
            return await Repo.GetAsync<State>();
        }

        public async Task<State> GetAsync(int id)
        {
            return await Repo.GetAsync<State>(id);
        }

        public async Task<State> InsertAsync(State newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
