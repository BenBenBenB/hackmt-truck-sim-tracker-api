using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;
public class Job : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Company { get; set; } = string.Empty;

    [ForeignKey(typeof(Cargo))]
    public int CargoId { get; set; }
    public int Value { get; set; }
    public int Pay { get; set; }

    [ForeignKey(typeof(city))]
    public int StartCityId { get; set; }
    [ForeignKey(typeof(city))]
    public int EndCityId { get; set; }

    public bool Perfect { get; set; } = false; 
}