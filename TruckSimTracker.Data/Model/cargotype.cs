using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;
public class cargotype : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = string.Empty;
    [ForeignKey(typeof(Dlc))]
    public int DlcId { get; set; }
}