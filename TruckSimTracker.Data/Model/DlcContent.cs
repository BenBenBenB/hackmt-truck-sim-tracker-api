using SQLite;

namespace TruckSimTracker.Data.Models
{
    public class DlcContent : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        [Unique]
        public string Name { get; set; } = string.Empty;
    }
}