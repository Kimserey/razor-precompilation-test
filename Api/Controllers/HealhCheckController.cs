using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/healthcheck")]
    [ApiController]
    public class HealhCheckController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
