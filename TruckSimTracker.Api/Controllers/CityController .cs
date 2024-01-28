using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Models; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        private readonly ICityService _CityService;

        public CityController(ILogger<CityController> logger, ICityService CityService)
        {
            _logger = logger;
            _CityService = CityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _CityService.GetAsync();
            var result = data.Select(x => new City
            {
                Id = x.Id,
                Updated = x.Updated,
                StateId = x.StateId,
                Name = x.Name, 

            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.City newItem)
        {
            var result = await _CityService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
