using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;


    public class City : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        [ForeignKey(typeof(State))]
        public int StateId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Visited { get; set; } = false; 

    }
