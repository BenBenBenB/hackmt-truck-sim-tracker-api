using TruckSimTracker.Data.Models;

namespace TruckSimTracker.Services.Dto;

public class AchievementDto
{

    public int Id { get; set; }
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public bool IsDlc { get; set; }
}
