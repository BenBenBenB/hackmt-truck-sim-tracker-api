using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Services
{
    public interface IDlcContentService
    {
        Task<List<DlcContent>> GetAsync();
        Task<DlcContent> GetAsync(int id);
        Task<DlcContent> InsertAsync(DlcContent newItem);
    }
    public class DlcContentService : IDlcContentService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public DlcContentService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<Data.Model.DlcContent>> GetAsync()
        {
            return await Repo.GetAsync<Data.Model.DlcContent>();
        }

        public async Task<Data.Model.DlcContent> GetAsync(int id)
        {
            return await Repo.GetAsync<Data.Model.DlcContent>(id);
        }

        public async Task<Data.Model.DlcContent> InsertAsync(Data.Model.DlcContent newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
