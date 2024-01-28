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
        private readonly IAchivementService _AchivementService;

        public AchivementController(ILogger<AchivementController> logger, IAchivementService AchivementService)
        {
            _logger = logger;
            _AchivementService = AchivementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _AchivementService.GetAsync();
            var result = data.Select(x => new Achivement
            {
                Id = x.Id,
                Description = x.Description,
                CargoId = x.CargoId,
                StateId = x.StateId,
                CityId = x.CityId,
                Name = x.Name,  
                Updated = x.Updated,
//                ImageSrc = x.ImageSrc, 

            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Achivement newItem)
        {
            var result = await _AchivementService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
