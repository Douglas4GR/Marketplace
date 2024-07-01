using Marketplace.Data;
using Marketplace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly MarketplaceContext _context;

        public OrderController(MarketplaceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            var product = await _context.Products.FindAsync(order.Sku);
            if (product == null)
            {
                _context.Products.Add(new Product { Sku = order.Sku, Name = order.ProductName, StockQuantity = 0 });
                order.Status = "NotExists";
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                return Ok(order);
            }

            if (product.StockQuantity >= order.QuantityPurchased)
            {
                product.StockQuantity -= order.QuantityPurchased;
                order.Status = "Completed";
            }
            else
            {
                order.Status = "AwaitingStock";
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok(order);
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetOrderHistory()
        {
            var completedOrders = await _context.Orders.Where(o => o.Status == "Completed").ToListAsync();
            return Ok(completedOrders);
        }

        [HttpGet("{id}/status")]
        public async Task<IActionResult> GetOrderStatus(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            var status = new OrderStatus { OrderId = order.OrderId, Status = order.Status };
            return Ok(status);
        }
    }

}
