using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Models; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepotController : ControllerBase
    {
        private readonly ILogger<DepotController> _logger;
        private readonly IDepotService _DepotService;

        public DepotController(ILogger<DepotController> logger, IDepotService DepotService)
        {
            _logger = logger;
            _DepotService = DepotService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _DepotService.GetAsync();
            var result = data.Select(x => new Depot
            {
                Id = x.Id,
                Updated = x.Updated,
                Name = x.Name,
                CityId = x.CityId,
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Depot newItem)
        {
            var result = await _DepotService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
