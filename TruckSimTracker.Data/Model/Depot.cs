using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;


public class Depot : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    [ForeignKey(typeof(City))]
    public int CityId { get; set; }
    public string Name { get; set; } = string.Empty;


}
