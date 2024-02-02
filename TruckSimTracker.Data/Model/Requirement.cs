using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;

public class Requirement : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public DateTime Updated { get; set; } = DateTime.UtcNow; 

    public string Description { get; set; } = string.Empty;

    public int? RequiredCount { get; set; }

    [Ignore]
    public bool Fulfilled { get; set; } = false;

    [ForeignKey(typeof(Achievement))]
    public int AchievementId { get; set; }
    
    // non-null Foreign keys imply job requires that key's value

    [ForeignKey(typeof(Depot))]
    public int? OriginDepotId { get; set; }

    [ForeignKey(typeof(Depot))]
    public int? TargetDepotId { get; set; }

    [ForeignKey(typeof(City))]
    public int? OriginCityId { get; set; }

    [ForeignKey(typeof(City))]
    public int? TargetCityId { get; set; }

    [ForeignKey(typeof(Cargo))]
    public int? CargoId { get; set; }


    [ManyToOne]
    public Achievement Achievement { get; set; }
    
    [OneToOne(nameof(Depot), "OriginDepotId")]
    public Depot? OriginDepot {  get; set; }

    [OneToOne(nameof(Depot), "TargetDepotId")]
    public Depot? TargetDepot { get; set; }

    [OneToOne(nameof(City), "OriginCityId")]
    public City? OriginCity { get; set; }

    [OneToOne(nameof(City), "TargetCityId")]
    public City? TargetCity { get; set; }

    [OneToOne(nameof(City))]
    public Cargo? Cargo { get; set; }

}