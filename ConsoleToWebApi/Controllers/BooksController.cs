using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "Hello Id" + id;
        }

        [Route("{id}")]
        public string GetByIdString(string id)
        {
            return "Hello string " + id;
        }
    }
}
