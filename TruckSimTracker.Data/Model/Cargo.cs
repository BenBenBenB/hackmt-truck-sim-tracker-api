﻿using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TruckSimTracker.Data.Model;

public class Cargo : ITruckSimTrackerDataModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    [Unique]
    public string Name { get; set; } = string.Empty;

    [ForeignKey(typeof(CargoType))]
    public int CargoTypeId { get; set; }

    [ForeignKey(typeof(DlcContent))]
    public int DlcContentId { get; set; }


    [ManyToOne]
    public CargoType CargoType { get; set; }

    [ManyToOne]
    public DlcContent DlcContent { get; set; }
}
