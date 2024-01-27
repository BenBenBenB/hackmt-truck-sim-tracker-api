using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;


    public class Dlc : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
        public bool owned { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.None)]
        public List<stte> States { get; set; } = default!;
  
}
