using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;

public class Client : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    
    public string Name { get; set; } = string.Empty;
    
    [ForeignKey(typeof(DlcContent))]
    public int DlcContentId { get; set; }


    [OneToOne(CascadeOperations = CascadeOperation.CascadeRead)]
    public DlcContent DlcContent { get; set; } = default!;
}
