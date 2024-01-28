using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Api
{

    public class Achivement
    {
        //public string ImageSrc { get; set; }
        public int Id { get; set; }
        public DateTime Updated { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 
        public int CargoId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
    }
}