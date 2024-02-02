using SQLite;
using SQLiteNetExtensions.Attributes;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Api;

public class CargoType 
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    public DateTime Updated { get; set; } 
    
    public string Name { get; set; } 
    
    [ForeignKey(typeof(DlcContent))]
    public int DlcContentId { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Cargo> Cargos { get; set; }
}
