using SQLite;
using TruckSimTracker.Data;

namespace TruckSimTracker.Api
{

    public class Depot 
    {
        public int Id { get; set; }
        public DateTime Updated { get; set; } 
        public int CityId { get; set; }
        public string Name { get; set; } 


    }
}