namespace TruckSimTracker.Services
{
    public interface ISteamworksService
    {
        Task<object> GetPlayerSaveAsync();
    }
    public class SteamworksService : ISteamworksService
    {

        public SteamworksService() { }

        // need to figure out type of what we want to return
        public Task<object> GetPlayerSaveAsync()
        {
            // todo. for now, return static file for testing
            throw new NotImplementedException();
        }
    }
}
