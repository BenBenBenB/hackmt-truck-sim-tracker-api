using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Model; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoTypeController : ControllerBase
    {
        private readonly ILogger<CargoTypeController> _logger;
        private readonly ICargoTypeService _CargoTypeService;

        public CargoTypeController(ILogger<CargoTypeController> logger, ICargoTypeService CargoTypeService)
        {
            _logger = logger;
            _CargoTypeService = CargoTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _CargoTypeService.GetAsync();
            var result = data.Select(x => new CargoType
            {
                Id = x.Id,
                Updated = x.Updated,
                Name = x.Name,
                DlcContentId = x.DlcContentId,
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.CargoType newItem)
        {
            var result = await _CargoTypeService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
