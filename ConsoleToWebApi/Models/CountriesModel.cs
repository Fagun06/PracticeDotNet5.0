using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Models
{
    [ModelBinder(typeof(CustomBinderCountryDetails))]
    public class CountriesModel
    {
        public int id { get; set; }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
    }
}
