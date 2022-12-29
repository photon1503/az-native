using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace second_dapr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet(Name = "Greet")]
        public ActionResult<string> Greet()
        {
            return "Hi There";
        }
    }
}
