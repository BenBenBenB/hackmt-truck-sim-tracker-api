using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using TruckSimTracker.Services;
using Models = TruckSimTracker.Data.Model; 

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly ILogger<JobController> _logger;
        private readonly IJobService _JobService;

        public JobController(ILogger<JobController> logger, IJobService JobService)
        {
            _logger = logger;
            _JobService = JobService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _JobService.GetAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.Job newItem)
        {
            var result = await _JobService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
