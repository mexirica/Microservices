namespace Microservices.CAS.Business;

using System.Security.Cryptography;
using System.Text;

public static class HashHelper
{
    public static string ComputeHash(byte[] data)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(data);
            StringBuilder hashString = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                hashString.Append(b.ToString("x2"));
            }
            return hashString.ToString();
        }
    }
}
