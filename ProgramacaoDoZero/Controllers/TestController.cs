using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    [HttpGet]
    [Route("getTestMessage")]
    public string GetTestMessage()
    {
        return "Teste ok!";
    }
}
