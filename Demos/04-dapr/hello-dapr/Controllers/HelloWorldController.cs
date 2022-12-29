using Microsoft.AspNetCore.Mvc;

namespace hello_dapr.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "SayHello")]
    public ActionResult<string> SayHello()
    {
        return "Hello, World";
    }
}
