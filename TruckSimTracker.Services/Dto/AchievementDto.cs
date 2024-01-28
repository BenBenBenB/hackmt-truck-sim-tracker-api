using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSimTracker.Services.Dto
{
    public class AchievementDto
    {
        int Id { get; init; }
        string Name { get; init; }
        string Description { get; init; }
        string ImageUrl { get; init; }
    }
}
