using Microsoft.AspNetCore.Mvc;

namespace OlaMundo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OlaMundoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Olá Daisy!";
        }

        [HttpPost]
        public string Post(string frase)
        {
            return frase;
        }

        [HttpGet]
        public int Soma(int p1, int p2)
        {
            return p1+p2;
        }

        [HttpGet]
        public string Cumprimentar(string cumprimento )
        {
            if (cumprimento == "Good Morning")
            {
                return "Bom Dia";
            }
            return "Não entendi!";
        }
    }

}