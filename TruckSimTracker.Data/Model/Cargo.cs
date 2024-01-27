using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;

    public class Cargo : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        [Unique]
        public string Name { get; set; } = string.Empty;

        [ForeignKey(typeof(CargoType))]
        public int cargotypeId { get; set; }
    }
