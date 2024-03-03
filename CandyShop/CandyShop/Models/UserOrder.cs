namespace CandyShop.Models
{
    public class UserOrder
    {
        public List<Product> Products { get; set; }
        public UserAddress Address { get; set; }
    }
}
