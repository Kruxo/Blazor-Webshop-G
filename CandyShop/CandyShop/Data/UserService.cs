using Microsoft.EntityFrameworkCore;

namespace CandyShop.Data
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> GetUserProductsInfo(ApplicationUser user)
        {
            return _context.Users.Include(u => u.Products).First(u => u.Id == user.Id);
        }
    }
}