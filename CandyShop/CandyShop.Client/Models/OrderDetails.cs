namespace CandyShop.Client.Models
{
    public class OrderDetails
    {
        public List<ClientProduct> Products { get; set; }
        public UserAddress Address { get; set; }
    }
}
