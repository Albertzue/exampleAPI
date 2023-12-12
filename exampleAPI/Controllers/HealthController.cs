using Microsoft.AspNetCore.Mvc;

namespace exampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            var version = "2023/12/12";
            return Content(version);
        }
    }
}
