
namespace TruckSimTracker.Api
{ 
    
    public class State 
    {
        
        public int Id { get; set; }
        public DateTime Updated { get; set; } 
        public int DlcContentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;

    }



}
