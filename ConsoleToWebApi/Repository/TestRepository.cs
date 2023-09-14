using ConsoleToWebApi.Models;
using System.Collections.Generic;

namespace ConsoleToWebApi.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "name from testripository";
        }
    }
}
