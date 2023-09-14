using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    
    [ApiController]

    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        public string Get()
        {
            return "Hello get";
        }
        
        public string Get1()
        {
            return "Hello get1";
        }


        public string GetById(int id)
        {
            return "Hello "+ id;
        }
    }
}
