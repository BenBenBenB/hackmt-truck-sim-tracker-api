using SQLite;
using System.Data;
using System.Reflection;
namespace TruckSimTracker.Data.Repositories;

public interface ITruckSimTrackerRepository
{
    public Task<List<T>> GetAsync<T>() where T : ITruckSimTrackerDataModel, new();
    public Task<T> GetAsync<T>(int id) where T : ITruckSimTrackerDataModel, new();
    public Task<T> InsertAsync<T>(T newItem) where T : ITruckSimTrackerDataModel, new();
    public Task<T> UpdateAsync<T>(T dataItem) where T : ITruckSimTrackerDataModel, new();
    public Task ResetTableAsync<T>() where T : ITruckSimTrackerDataModel, new();
}

public class TruckSimTrackerRepository(string dbPath) : ITruckSimTrackerRepository
{
    public static readonly string ModelNameSpace = "TruckSimTracker.Data.Models";

    private string _dbPath = dbPath;
    private SQLiteAsyncConnection _conn = default!;

    private async Task InitAsync()
    {
        if (_conn != null)
            return;
        _conn = new SQLiteAsyncConnection(_dbPath);

#if DEBUG
        await ResetAllTablesAsync();
        await DebugData.PopulateTables(this);
#endif

        await CreateTables();
    }

    private async Task CreateTables()
    {
        Type[] dataModels = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.Namespace == ModelNameSpace)
            .ToArray();

        await _conn.CreateTablesAsync(CreateFlags.None, dataModels);
    }

    // for debug, probably
    public async Task ResetAllTablesAsync()
    {
        Task.WaitAll(
            _conn.DropTableAsync<Models.Achivement>(),
            _conn.DropTableAsync<Models.Cargo>(),
            _conn.DropTableAsync<Models.CargoType>(),
            _conn.DropTableAsync<Models.City>(),
            _conn.DropTableAsync<Models.DlcContent>(),
            _conn.DropTableAsync<Models.Job>(),
            _conn.DropTableAsync<Models.State>(),
            _conn.DropTableAsync<Models.Depot>()
        );
        await CreateTables();
    }

    public async Task ResetTableAsync<T>() where T : ITruckSimTrackerDataModel, new()
    {
        await InitAsync();
        await _conn.DropTableAsync<T>();
        await _conn.CreateTableAsync<T>();
    }

    public async Task<List<T>> GetAsync<T>() where T : ITruckSimTrackerDataModel, new()
    {
        List<T> result = [];
        try
        {
            await InitAsync();
            result = await _conn.Table<T>()
                .ToListAsync();
        }
        catch (Exception ex)
        {
        }
        return result;
    }

    public async Task<T> GetAsync<T>(int id) where T : ITruckSimTrackerDataModel, new()
    {
        T result = new();
        try
        {
            await InitAsync();
            result = await _conn.GetAsync<T>(id);
        }
        catch (Exception ex)
        {
        }
        return result ?? new();
    }

    public async Task<T> InsertAsync<T>(T newItem) where T : ITruckSimTrackerDataModel, new()
    {
        try
        {
            await InitAsync();
            await _conn.InsertAsync(newItem);
            return newItem;
        }
        catch (Exception ex)
        {
            return new();
        }
    }

    public async Task<T> UpdateAsync<T>(T dataItem) where T : ITruckSimTrackerDataModel, new()
    {
        try
        {
            await InitAsync();
            await _conn.UpdateAsync(dataItem);
            return dataItem;
        }
        catch (Exception ex)
        {
            return new();
        }
    }
}