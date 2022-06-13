namespace ShoppingWebApi.Model
{
    public class OrderModel
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
    }
}
