using System.Security.Cryptography;
using System.Text;

namespace PortfolioApi
{
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            SHA256 hasher = SHA256Managed.Create();

            var salt = "hrtushdyow";

            var bytePassword = Encoding.UTF8.GetBytes(password + salt);

            var encodedPassword =  hasher.ComputeHash(bytePassword);

            StringBuilder builder = new();

            foreach (var item in encodedPassword)
            {
                builder.Append(item.ToString("x2"));
            }

            var decodedPassword = builder.ToString();

            return decodedPassword;
        }
    }
}
