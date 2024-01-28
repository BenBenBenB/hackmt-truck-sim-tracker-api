
public class RequirermentsDto 
{
    public int Id { get; set; }
    public int AchievementId { get; set; }
    public string Description { get; set; } = string.Empty;
    public int NumberNeedded { get; set; } 
    public bool IsDone{ get; set; }
    public string StartingDepotName { get; set; }
    public string DestinationDepotName { get; set; }
    public string StartingCitytName { get; set; }
    public string DestinationCitytName { get; set; }
    public string CargoName { get; set; }
}