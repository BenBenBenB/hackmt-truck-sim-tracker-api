using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Reflection;
namespace TruckSimTracker.Data.Models;

public class Requirerments : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
//  public string ImageSrc { get; set; } = string.Empty;
    
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow; 
    public string Description { get; set; } = string.Empty;
    public int NumberNeedded { get; set; } 

    [ForeignKey(typeof(Depot))]
    public int StartingDepotId { get; set; }

    [ForeignKey(typeof(Depot))]
    public int DestinationDepotId { get; set; }

    [ForeignKey(typeof(City))]
    public int StartingCitytId { get; set; }

    [ForeignKey(typeof(City))]
    public int DestinationCitytId { get; set; }

    [ForeignKey(typeof(Cargo))]
    public int CargoId { get; set; }
    [ForeignKey(typeof(Achievement))]
    public int AchievementId { get; set; }

}