using CandyShop.Models;
using Microsoft.AspNetCore.Identity;

namespace CandyShop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }

}