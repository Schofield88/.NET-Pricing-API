namespace PricingApi.Models {
    public class OrderItem {
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public decimal Unit_price { get; set; }
        public decimal Unit_vat { get; set; }
        public decimal Sub_total { get; set; }
        public decimal Sub_vat { get; set; }
    }

}