using Microsoft.AspNetCore.Mvc;

namespace ApiDashboard.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AutoTestController : ControllerBase
    {
        public ActionResult GetAutoTest() {
            return Ok(200);
        }
    }
}
