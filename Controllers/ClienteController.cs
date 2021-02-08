using Microsoft.AspNetCore.Mvc;
using OlaMundo.Classes;

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

        [HttpPost]
        public ClienteEnvioModel Post([FromBody] ClienteEnvioModel cliente)
        {
            //return $"{cliente.Nome} {cliente.Sobrenome}";
            //return string.Format("{0} {1}", cliente.Nome, cliente.Sobrenome);
            return cliente;
        }
    }
}