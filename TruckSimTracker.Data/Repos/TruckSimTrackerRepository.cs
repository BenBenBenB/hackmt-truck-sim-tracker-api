using SQLite;
using SQLiteNetExtensionsAsync.Extensions;
using System.Data;
using System.Reflection;
using TruckSimTracker.Data.Models;
namespace TruckSimTracker.Data.Repositories;

public interface ITruckSimTrackerRepository
{
    public Task<List<T>> GetAsync<T>(bool withChildren = false) where T : ITruckSimTrackerDataModel, new();
    public Task<T> GetAsync<T>(int id, bool withChildren = false) where T : ITruckSimTrackerDataModel, new();
    public Task InsertAsync<T>(T newItem) where T : ITruckSimTrackerDataModel, new();
    public Task UpdateAsync<T>(T dataItem) where T : ITruckSimTrackerDataModel, new();
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
    public async Task ResetTableAsync<T>() where T : ITruckSimTrackerDataModel, new()
    {
        await InitAsync();
        await _conn.DropTableAsync<T>();
        await _conn.CreateTableAsync<T>();
    }

    public async Task<List<T>> GetAsync<T>(bool withChildren = false) where T : ITruckSimTrackerDataModel, new()
    {
        List<T> result = [];
        try
        {
            await InitAsync();
            if (withChildren)
            {
                var data = await _conn.GetAllWithChildrenAsync<T>();
                result = data
                    .ToList();
            }
            else
            {
                result = await _conn.Table<T>()
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
        }
        return result;
    }

    public async Task<T> GetAsync<T>(int id, bool withChildren = false) where T : ITruckSimTrackerDataModel, new()
    {
        T result = new();
        try
        {
            await InitAsync();
            if (withChildren)
            {
                result = await _conn.GetWithChildrenAsync<T>(id);
            }
            else
            {
                result = await _conn.GetAsync<T>(id);
            }
            string message = result?.Id != null
                ? $"Found. Record id: {id}"
                : $"Not found. Record id: {id}";
        }
        catch (Exception ex)
        {
        }
        return result ?? new();
    }

    public async Task InsertAsync<T>(T newItem) where T : ITruckSimTrackerDataModel, new()
    {
        try
        {
            await InitAsync();
            await _conn.InsertAsync(newItem);
        }
        catch (Exception ex)
        {
        }
    }

    public async Task UpdateAsync<T>(T dataItem) where T : ITruckSimTrackerDataModel, new()
    {
        try
        {
            await InitAsync();
            await _conn.UpdateAsync(dataItem);
        }
        catch (Exception ex)
        {
        }
    }
}