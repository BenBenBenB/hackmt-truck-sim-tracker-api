using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Reflection;
namespace TruckSimTracker.Data.Model;

public class Achievement : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public DateTime Updated { get; set; } = DateTime.UtcNow;

    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    [Ignore]
    public bool Completed { get; set; } = false;


    [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
    public List<Requirement> Requirements { get; set; }
}