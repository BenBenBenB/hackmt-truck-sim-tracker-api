using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Model; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StateController : ControllerBase
    {
        private readonly ILogger<StateController> _logger;
        private readonly IStateService _StateService;

        public StateController(ILogger<StateController> logger, IStateService StateService)
        {
            _logger = logger;
            _StateService = StateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _StateService.GetAsync();
            var result = data.Select(x => new State
            {
                Id = x.Id,
                Updated = x.Updated,
                DlcContentId = x.DlcContentId,
                Abbreviation = x.Abbreviation,
                Name = x.Name, 
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.State newItem)
        {
            var result = await _StateService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
