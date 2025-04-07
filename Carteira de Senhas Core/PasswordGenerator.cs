using System.Security.Cryptography;
using System.Text;

namespace Carteira_de_Senhas_Core
{
    internal class PasswordGenerator
    {
        public string GenerateRandomPassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*_+";
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[15];
                rng.GetBytes(randomBytes);

                StringBuilder password = new StringBuilder(15);
                int validCharCount = validChars.Length;

                foreach (byte b in randomBytes)
                {
                    password.Append(validChars[b % validCharCount]);
                }
                return password.ToString();
            }
        }
    }
}
