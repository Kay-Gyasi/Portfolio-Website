using Data.DBContext;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApi
{
    public class Login
    {
        PortfolioContext _context = new();
        public async Task<bool> ApiLogin(string username, string password)
        {
            PasswordHasher encoder = new();
            password = encoder.HashPassword(password).ToString();
            bool isValid = await Task.Run(() => _context.Admins.Any(a => a.Name == username && a.Password == password));
            return isValid;
        }
    }
}
