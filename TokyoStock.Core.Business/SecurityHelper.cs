using System.Security.Cryptography;
using System.Text;

namespace TokyoStock.Core.Business
{
    public class SecurityHelper
    {
        public static byte[] GenerateSalt()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return salt;
            }
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

            Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

            byte[] hashedBytes = SHA256.HashData(saltedPassword);

            return hashedBytes;
        }

        public static string HashPassword1Hex(string password, byte[] salt)
        {
            return Convert.ToBase64String(HashPassword(password, salt));
        }

    }
}
