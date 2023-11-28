using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/outroTesteController")]
public class OutroTesteController : ControllerBase
{

    [HttpGet]
    [Route("ObterMensagemTeste")]
    public string ObterMensagemTeste()
    {
        return "Teste ok!";
    }
}
