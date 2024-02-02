using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;

public class City : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = string.Empty;
    [ForeignKey(typeof(State))]
    public int StateId { get; set; }


    [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
    public State State { get; set; } = default!;
}
