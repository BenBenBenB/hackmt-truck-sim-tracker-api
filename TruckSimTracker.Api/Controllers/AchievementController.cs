using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Models; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AchievementController : ControllerBase
    {
        private readonly ILogger<AchievementController> _logger;
        private readonly IAchievementService _AchievementService;

        public AchievementController(ILogger<AchievementController> logger, IAchievementService AchievementService)
        {
            _logger = logger;
            _AchievementService = AchievementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _AchievementService.GetAsync();
            var result = data.Select(x => new Achievement
            {
                Id = x.Id,
                Description = x.Description,
                CargoId = x.CargoId,
                StateId = x.StateId,
                CityId = x.CityId,
                Name = x.Name,  
                Updated = x.Updated,
                ImageUrl = x.ImageUrl
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Achievement newItem)
        {
            var result = await _AchievementService.InsertAsync(newItem);
            return Ok(result);
        }
        public async requirementsDto GetRequriermentsAsync(int id) 
        {

        }
    }

}
