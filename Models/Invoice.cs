namespace PricingApi.Models {
    public class Invoice {
        public decimal Order_net { get; set; }
        public decimal Order_vat { get; set; }
        public decimal Order_gross { get; set; }
        public OrderItem[] Items { get; set; }
    }

}