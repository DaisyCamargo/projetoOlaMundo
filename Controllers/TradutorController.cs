using Microsoft.AspNetCore.Mvc;

namespace Tradutor.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TradutorController : ControllerBase
    {

        [HttpGet]
        public string Traduzir(string cumprimento)
        {
            if (cumprimento == "Bom dia")
            {
                return "Good Morning!";
            }
            else if (cumprimento == "Boa tarde")
            {
                return "Good Afternoon!";
            }
            else if (cumprimento == "Boa noite")
            {
                return "Good Night!";
            }
            else
            {
                return "Não entendi!";
            }
        }
    }

}