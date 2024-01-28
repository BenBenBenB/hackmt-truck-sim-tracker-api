using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using TruckSimTracker.Services.Dto;
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
            var result = data.Select(x => new AchievementDto
            {
                Id = x.Id,
                Name = x.Name,  
                Description = x.Description,
                IsDlc = x.IsDlc,
                ImageUrl = x.ImageUrl,
                

    });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Achievement newItem)
        {
            var result = await _AchievementService.InsertAsync(newItem);
            return Ok(result);
        }
        //public async Task<List<RequirementDto>> GetRequirementsAsync(int id) 
        //{
        //}
    }

}
