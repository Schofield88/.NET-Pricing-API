using Newtonsoft.Json;

namespace PricingApi.Models
{
    public partial class CustomerOrder
    {
        [JsonProperty("order")]
        public Order Order { get; set; }
    }

    public partial class Order
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Customer { }

    public partial class Item
    {
        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}