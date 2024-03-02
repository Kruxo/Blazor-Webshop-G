namespace CandyShop.Client.Models
{
    public class OrderDetailsModel
    {
        public List<ClientProduct> Products { get; set; }
        public UserAddress Address { get; set; }
    }
}
