using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;

public class DlcContent : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }  // All FKs to here imply requirement of DLC purchase / seasonal event

    public DateTime Updated { get; set; } = DateTime.UtcNow;

    [Unique]
    public string Name { get; set; } = string.Empty;

    // Foreign keys that point here
    [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
    public List<Client> Clients { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
    public List<State> States { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
    public List<CargoType> CargoTypes { get; set; }
}