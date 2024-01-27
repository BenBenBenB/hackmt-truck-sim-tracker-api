using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;
public class job : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Company { get; set; } = string.Empty;

    [ForeignKey(typeof(Cargo))]
    public int cargoid { get; set; }
    public int value { get; set; }

    [ForeignKey(typeof(city))]
    public int stratcityId { get; set; }
    [ForeignKey(typeof(city))]
    public int endcityId { get; set; }
    public int pay { get; set; }

    public bool nodamage_on_job { get; set; }


}