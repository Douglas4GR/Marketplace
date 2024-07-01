using Marketplace.Data;
using Marketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly MarketplaceContext _context;

        public ProductController(MarketplaceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var existingProduct = await _context.Products.FindAsync(product.Sku);
            if (existingProduct != null)
            {
                existingProduct.StockQuantity += product.StockQuantity;
            }
            else
            {
                _context.Products.Add(product);
            }

            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }

}
