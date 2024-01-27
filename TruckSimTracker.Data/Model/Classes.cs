using System;
using SQLite;

namespace TruckSimTracker.Data.Models
{

    public class Dlc : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
        public bool owned { get; set; }
    }

    public class cargotype : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
        public int DlcId{ get; set; }
    }
    public class Cargo : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
        public int numberofcompleted { get; set; } 
        public int cargotypeId { get; set;}
    }

    public class stte : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
        public int DlcId {  get; set; } 
    }

    public class city : ITruckSimTrackerDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty;
        public bool visited { get; set; }
        public int stateId { get; set; }
    }
}