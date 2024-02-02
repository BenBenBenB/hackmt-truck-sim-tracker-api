using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;

public class State : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public DateTime Updated { get; set; } = DateTime.UtcNow;

    public string Name { get; set; } = string.Empty;

    public string Abbreviation { get; set; } = string.Empty;

    [ForeignKey(typeof(DlcContent))]
    public int DlcContentId { get; set; }


    [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
    public List<City> Cities { get; set; } = default!;

    [OneToOne(CascadeOperations = CascadeOperation.CascadeRead)]
    public DlcContent DlcContent { get; set; } = default!;
}
