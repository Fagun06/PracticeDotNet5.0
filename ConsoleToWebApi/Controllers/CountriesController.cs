using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
       // [BindProperty(SupportsGet = true)]
       // public CountriesModel Country { get; set; }
        [HttpPost("{id}")]
        public IActionResult AddConuntry([FromBody] int id)
        {
            return Ok($"Name = {id}");
        }

        [HttpGet("search")]

        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))]string[] countries)
        {
            return Ok(countries);
        }
        [HttpGet("{id}")]

        public IActionResult CountryDetails([ModelBinder(Name="Id")]CountriesModel country)
        {
            return Ok(country);
        }
    }
}
