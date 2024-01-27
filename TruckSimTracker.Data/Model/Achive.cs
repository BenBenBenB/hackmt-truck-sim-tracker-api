using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;
public class Achivements : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty; 
    [ForeignKey(typeof(Cargo))]
    public int cargoId { get; set; }
    [ForeignKey(typeof(stte))]
    public int stateId { get; set; }
    [ForeignKey(typeof(city))]
    public int cityId { get; set; }

}