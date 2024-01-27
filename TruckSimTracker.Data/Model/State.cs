using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;

public class State : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    [ForeignKey(typeof(DlcContent))]
    public int DlcContentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Abbreviation { get; set; } = string.Empty;

    [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
    public List<City> Cities { get; set; } = default!;
}


