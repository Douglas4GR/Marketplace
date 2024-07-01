namespace Marketplace.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime PaymentsDate { get; set; }
        public string BuyerEmail { get; set; }
        public string BuyerName { get; set; }
        public string Cpf { get; set; }
        public long BuyerPhoneNumber { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public int QuantityPurchased { get; set; }
        public string Currency { get; set; }
        public decimal ItemPrice { get; set; }
        public string ShipServiceLevel { get; set; }
        public string RecipientName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string IossNumber { get; set; }
        public string Status { get; set; }  // "Completed", "AwaitingStock", "NotExists"
    }
}
