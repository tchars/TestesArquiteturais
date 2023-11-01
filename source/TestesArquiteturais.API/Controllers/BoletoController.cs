using Microsoft.AspNetCore.Mvc;

namespace com.tchars.TestesArquiteturais.API.Controllers
{
    [ApiController]
    [Route("boletos")]
    public class BoletoController : ControllerBase
    {
        public BoletoController() { }

        [HttpGet]
        public IActionResult Get()
            => Ok();
    }
}