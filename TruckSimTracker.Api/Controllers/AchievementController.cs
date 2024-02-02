using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using TruckSimTracker.Services.Dto;
using Models = TruckSimTracker.Data.Model; 

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
            var result = data.Select(x => new AchievementDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                DlcName = "Todo",
                ImageUrl = x.ImageUrl,

            });
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAchievementAsync(int id)
        {
            var result = await _AchievementService.GetWithChildrenAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Achievement newItem)
        {
            var result = await _AchievementService.InsertAsync(newItem);
            return Ok(result);
        }
    }

}
