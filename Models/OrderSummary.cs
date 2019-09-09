using Newtonsoft.Json;

namespace PricingApi.Models
{
    public partial class OrderSummary
    {
        [JsonProperty("invoice")]
        public Invoice Invoice { get; set; }
    }

    public partial class Invoice
    {
        [JsonProperty("order_net")]
        public decimal OrderNet { get; set; }

        [JsonProperty("order_vat")]
        public decimal OrderVat { get; set; }

        [JsonProperty("order_gross")]
        public decimal OrderGross { get; set; }

        [JsonProperty("items")]
        public OrderItem[] Items { get; set; }

    }

    public partial class OrderItem
    {
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("unit_price")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("unit_vat")]
        public decimal UnitVat { get; set; }

        [JsonProperty("sub_total")]
        public decimal Sub_total { get; set; }

        [JsonProperty("sub_vat")]
        public decimal SubVat { get; set; }

    }
}