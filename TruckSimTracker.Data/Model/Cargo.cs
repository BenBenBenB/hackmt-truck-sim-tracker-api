using SQLite;

namespace TruckSimTracker.Data.Models
{
    public class Cargo : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
    }
    