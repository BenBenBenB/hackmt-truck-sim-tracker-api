using SQLite;
using TruckSimTracker.Data;

namespace TruckSimTracker.Api
{

    public class City 
    {
        public int Id { get; set; }
        public DateTime Updated { get; set; } 
        public int StateId { get; set; }
        public string Name { get; set; } 


    }

}
