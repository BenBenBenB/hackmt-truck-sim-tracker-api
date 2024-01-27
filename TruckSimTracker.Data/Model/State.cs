using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Models;

    public class stte : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        [ForeignKey(typeof(Dlc))]
        public int DlcId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string abrev { get; set; } = string.Empty;
        [OneToMany(CascadeOperations = CascadeOperation.None)]
        public List<city> Cities { get; set; } = default!;
        public bool basegame { get; set; } 

}


