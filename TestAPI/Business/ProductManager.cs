using System.Collections.Generic;
using TestAPI.Models;

namespace TestAPI.Business
{
    public interface IProductManager
    {
        List<Product> GetProducts();
    }

    public class ProductManager : IProductManager
    {
        public List<Product> GetProducts()
        {
            return null;
        }
    }

}
