using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class PasswordEncrypt
    {
        public static string GenerateSalt(int length)
        {
            byte[] salt = new byte[length];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        public string HashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000))
            {
                byte[] hashBytes = pbkdf2.GetBytes(20);
                byte[] combinedBytes = new byte[hashBytes.Length + saltBytes.Length];
                Buffer.BlockCopy(hashBytes, 0, combinedBytes, 0, hashBytes.Length);
                Buffer.BlockCopy(saltBytes, 0, combinedBytes, hashBytes.Length, saltBytes.Length);
                return Convert.ToBase64String(combinedBytes);
            }
        }

        public bool VerifyPassword(string password, byte[] hashedPassword)
        {
            byte[] hashBytes = new byte[20];
            byte[] saltBytes = new byte[hashedPassword.Length - hashBytes.Length];
            Buffer.BlockCopy(hashedPassword, 0, hashBytes, 0, hashBytes.Length);
            Buffer.BlockCopy(hashedPassword, hashBytes.Length, saltBytes, 0, saltBytes.Length);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000))
            {
                byte[] newHashBytes = pbkdf2.GetBytes(20);
                return StructuralComparisons.StructuralEqualityComparer.Equals(hashBytes, newHashBytes);
            }
        }
    }
}

