using ATOM.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ATOM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatheringCenterController : ControllerBase
    {
        private readonly IGatheringCenterService _gatheringCenterService;

        public GatheringCenterController(IGatheringCenterService gatheringCenterService)
        {
            _gatheringCenterService = gatheringCenterService;
        }


        [HttpGet]
        public async Task<IActionResult> GetNearestGatheringCenter(float longitude, float latitude)
        {
            var values = await _gatheringCenterService.NearGatheringCenter(longitude, latitude);
            return Ok(new
            {
                Name = values.Item1.Name,
                Longitude = values.Item1.Longitude,
                Latitude = values.Item1.Latitude,
                Distance = values.distance,
                Type = values.Item1.CenterType.Name

            });
        }
    }
}
