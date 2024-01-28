using SQLite;
using TruckSimTracker.Data;
using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Api
{

    public class CargoType 
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } 
        public string Name { get; set; } 
        public int DlcContentId { get; set; }
    }

}
