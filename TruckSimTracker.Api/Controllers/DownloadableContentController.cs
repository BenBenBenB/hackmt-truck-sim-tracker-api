using Microsoft.AspNetCore.Mvc;
using TruckSimTracker.Api;
using Models = TruckSimTracker.Data.Models;
using TruckSimTracker.Services;

namespace TruckSimTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadableContentController : ControllerBase
    {
        private readonly ILogger<DownloadableContentController> _logger;
        private readonly IDlcContentService _dlcService;

        public DownloadableContentController(ILogger<DownloadableContentController> logger, IDlcContentService dlcService)
        {
            _logger = logger;
            _dlcService = dlcService;
        }

        [HttpGet]
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

        [HttpPost]
        public async Task<IActionResult> PostAsync(Models.DlcContent newItem)
        {
            var result = await _dlcService.InsertAsync(newItem);
            return Ok(result);
        }
    }
}
