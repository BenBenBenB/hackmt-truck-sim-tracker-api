using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;
public class Achievement : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    [ForeignKey(typeof(Cargo))]
    public int CargoId { get; set; }
    [ForeignKey(typeof(State))]
    public int StateId { get; set; }
    [ForeignKey(typeof(City))]
    public int CityId { get; set; }
}