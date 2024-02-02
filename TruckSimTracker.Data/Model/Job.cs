using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;
public class Job : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public DateTime Updated { get; set; } = DateTime.UtcNow;

    public string Company { get; set; } = string.Empty;

    public int Pay { get; set; }

    public int Exp { get; set; }

    public bool Perfect { get; set; } = false;

    [ForeignKey(typeof(Depot))]
    public int OriginDepotId { get; set; }

    [ForeignKey(typeof(Depot))]
    public int TargetDepotId { get; set; }

    [ForeignKey(typeof(Cargo))]
    public int CargoId { get; set; }


    [OneToOne(CascadeOperations = CascadeOperation.CascadeRead)]
    public Depot OriginDepot { get; set; }
    
    [OneToOne(CascadeOperations = CascadeOperation.CascadeRead)]
    public Depot TargetDepot { get; set; }

    [OneToOne(CascadeOperations = CascadeOperation.CascadeRead)]
    public Cargo Cargo { get; set; }
}