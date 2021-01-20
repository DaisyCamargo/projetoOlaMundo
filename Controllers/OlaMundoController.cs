using Microsoft.AspNetCore.Mvc;

namespace OlaMundo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OlaMundoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Olá Mundo!";
        }
        [HttpPost]
    public string Post(string frase)
    {
        return frase;
    }
}
}