namespace Marketplace.Models
{
    public class Product
    {
        public required string Sku { get; set; }
        public string? Name { get; set; }
        public int StockQuantity { get; set; }
    }
}
