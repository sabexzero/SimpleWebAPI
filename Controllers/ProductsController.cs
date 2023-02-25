using Microsoft.AspNetCore.Mvc;

namespace need.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _products;
        public ProductsController(IProductService productService)
        {
            _products = productService;
        }
        // Get all products
        [HttpGet("AllProducts")]
        public async Task<IEnumerable<Product>> Index()
        {
            return await _products.Select();
        }
        [HttpGet("OneProduct")]
        // Get concrete product by id
        public async Task<Product> Details(int id)
        {
            return await _products.Get(id);
        }
        //Create product
        [HttpPost("CreateProduct")]
        public async Task<ActionResult<Product>> Create(int id, string title, decimal price)
        {
            Product product = new(id, title, price);
            await _products.Create(product);
            await _products.SaveChangesAsync();
            return Ok(product);
        }
        //Delete product
        [HttpDelete("DeleteProduct")]
        public async Task Delete(int id)
        {
            await _products.Delete(id);
            await _products.SaveChangesAsync();
        }
    }
}
