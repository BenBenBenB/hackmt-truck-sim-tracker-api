using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface IDlcContentService
    {
        Task<List<Data.Models.DlcContent>> GetAsync();
        Task<Data.Models.DlcContent> GetAsync(int id);
        Task<Data.Models.DlcContent> InsertAsync(Data.Models.DlcContent newItem);
    }
    public class DlcContentService : IDlcContentService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public DlcContentService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Data.Models.DlcContent>> GetAsync()
        {
            return await Repo.GetAsync<Data.Models.DlcContent>();
        }

        public async Task<Data.Models.DlcContent> GetAsync(int id)
        {
            return await Repo.GetAsync<Data.Models.DlcContent>(id);
        }

        public async Task<Data.Models.DlcContent> InsertAsync(Data.Models.DlcContent newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
