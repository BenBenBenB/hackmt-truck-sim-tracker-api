using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Services;

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadableContentController : ControllerBase
    {
        private readonly ILogger<DownloadableContentController> _logger;
        private readonly IDownloadableContentService _dlcService;

        public DownloadableContentController(ILogger<DownloadableContentController> logger, IDownloadableContentService dlcService)
        {
            _logger = logger;
            _dlcService = dlcService;
        }

        [HttpGet(Name = "Get")]
        public async Task<IActionResult> GetAsync()
        {
            var data = await _dlcService.GetAsync();
            var result = data.Select(x => new DownloadableContent
            {
                Id = x.Id,
                Name = x.Name,
            });
            return Ok(result);
        }
    }
}
