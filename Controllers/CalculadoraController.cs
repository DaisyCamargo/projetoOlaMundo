using Microsoft.AspNetCore.Mvc;

namespace COlaMundo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet]
        public float Calcular(float n1, float n2, float n3)
        {
            return (n1 + n2 + n3)/3;
        }

    }

}