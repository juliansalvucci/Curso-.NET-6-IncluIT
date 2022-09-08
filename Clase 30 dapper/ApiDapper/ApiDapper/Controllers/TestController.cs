using ApiDapper.Models;
using ApiDapper.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/api/products")]
        public List<Product> GetAllProducts() //El controlador llama a la regla, para la regla, la comunicación con dapper es transparente, por eso.
        {
            var rule = new ProductRule();
            return rule.GetAllProdcuts();
        }

        [HttpGet("/api/products/{id}")]
        public Product GetProduct(int id) 
        {
            var rule = new ProductRule();
            return rule.GetProdcutById(id);
        }

        [HttpDelete("/api/orders")]
        public bool DeleteOrderById(int orderId)
        {
            var rule = new OrderRule();
            rule.DeleteOrderById(orderId);
            return true;
        } 
    }
}
