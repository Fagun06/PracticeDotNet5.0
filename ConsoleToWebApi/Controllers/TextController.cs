using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [ApiController]
    [Route("text/[action]")]
    public class TextController : ControllerBase
    {
        public string Get()
        {
            return "Hello get";
        }
        public string Get1()
        {
            return "Hello get1";
        }
    }
}
