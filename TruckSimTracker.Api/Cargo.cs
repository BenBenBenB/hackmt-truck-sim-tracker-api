using SQLite;
using TruckSimTracker.Data;
using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Api
{

    public class Cargo 
    {
        public int Id { get; set; }
        public DateTime Updated { get; set; } 
        public string Name { get; set; }
        public int CargoTypeId { get; set; }
    }

}
