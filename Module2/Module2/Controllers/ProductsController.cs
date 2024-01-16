using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module2.Models;

namespace Module2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        static List<Product> _products = new List<Product>()
        {
          new Product() { ProductId = 0, ProductName = "Laptop", ProductPrice = "200" },
          new Product() { ProductId = 1, ProductName = "Phone", ProductPrice = "300" },
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        public void Post([FromBody] Product product)
        {
            _products.Add(product);
        }
    }
}
