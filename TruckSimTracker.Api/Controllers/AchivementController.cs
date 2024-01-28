using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Models; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AchivementController : ControllerBase
    {
        private readonly ILogger<AchivementController> _logger;
        private readonly IAchievementService _AchievementService;

        public AchivementController(ILogger<AchivementController> logger, IAchievementService AchievementService)
        {
            _logger = logger;
            _AchievementService = AchievementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _AchievementService.GetAsync();
            var result = data.Select(x => new Achivement
            {
                Id = x.Id,
                Description = x.Description,
                CargoId = x.CargoId,
                StateId = x.StateId,
                CityId = x.CityId,
                Name = x.Name,  
                Updated = x.Updated,

            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Achivement newItem)
        {
            var result = await _AchievementService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
