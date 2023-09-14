using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace ConsoleToWebApi
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName);

            var result = value.FirstValue;

            if(!int.TryParse(result,out var id))
            {
                return Task.CompletedTask;
            }

            var model = new CountriesModel()
            {
                id = id,
                Area = 400,
                Name = "bd",
                Population = 488
            };
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
