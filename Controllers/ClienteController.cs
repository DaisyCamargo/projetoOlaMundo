using Microsoft.AspNetCore.Mvc;

namespace OlaMundo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet("{idCLiente}")]
        public string Get(int idCliente)
        {
            if (idCliente == 1)
                return "Daisy";

            if (idCliente == 2)
                return "Darlene";

            return "Sarah";
        }
    }
}