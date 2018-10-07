using Microsoft.AspNetCore.Mvc;

namespace RazorPrecompilationTest.Controllers
{
    [Route("healthcheck")]
    public class HealhCheckController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
