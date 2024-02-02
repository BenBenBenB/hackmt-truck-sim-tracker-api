using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Model; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly ILogger<CargoController> _logger;
        private readonly ICargoService _CargoService;

        public CargoController(ILogger<CargoController> logger, ICargoService CargoService)
        {
            _logger = logger;
            _CargoService = CargoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _CargoService.GetAsync();
            var result = data.Select(x => new Cargo
            {
                Id = x.Id,
                Updated = x.Updated,
                Name = x.Name,
                CargoTypeId = x.CargoTypeId,
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Cargo newItem)
        {
            var result = await _CargoService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
