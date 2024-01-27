using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;


    public class city : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        [ForeignKey(typeof(stte))]
        public int stteId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool visited { get; set; } = false; 

    }
