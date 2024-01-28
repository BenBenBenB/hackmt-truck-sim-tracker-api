using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services
{
    public interface IDownloadableContentService
    {
        Task<List<DlcContent>> GetAsync();
        Task<DlcContent> GetAsync(int id);
        Task<DlcContent> InsertAsync(DlcContent newItem);
    }
    public class DownloadableContentService : IDownloadableContentService
    {
        private ITruckSimTrackerRepository Repo { get; set; }
        public DownloadableContentService(ITruckSimTrackerRepository repo)
        {
            Repo = repo;
        }

        public async Task<List<DlcContent>> GetAsync()
        {
            return await Repo.GetAsync<DlcContent>();
        }

        public async Task<DlcContent> GetAsync(int id)
        {
            return await Repo.GetAsync<DlcContent>(id);
        }

        public async Task<DlcContent> InsertAsync(DlcContent newItem)
        {
            return await Repo.InsertAsync(newItem);
        }
    }
}
