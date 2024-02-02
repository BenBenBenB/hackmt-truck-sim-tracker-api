namespace TruckSimTracker.Api
{

    public class Job 
    {
        
        public int Id { get; set; }
        public DateTime Updated { get; set; } 
        public string Company { get; set; } 
        public int CargoId { get; set; }
        public int Value { get; set; }
        public int Pay { get; set; }
        public int OriginDepotId { get; set; }
        public int TargetDepotId { get; set; }
        public bool Perfect { get; set; } 
    }
}
