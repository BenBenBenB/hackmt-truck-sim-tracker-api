namespace TruckSimTracker.Services.Dto;

public class JobDto
{
    public int Id { get; init; }
    public string CargoName { get; init; }
    public string DepotFromName { get; init; }
    public string DepotFromLocation { get; init; }
    public string DepotToName { get; init; }
    public string DepotToLocation { get; init; }
    public int Paid { get; init; }
    public int Exp { get; init; }
    public bool Perfect { get; init; }
}
