using System;
using System.Security.Cryptography;
using System.Text;

namespace Casino.BLL.Common
{
    public static class CommonFunctions
    {
        public static int GenerateSalt()
        {
            int salt = new Random().Next(100000, int.MaxValue);
            return salt;
        }

        public static string HashPasswordAndSetSalt(string password, int salt)
        {
            string passwordHash = ComputeUserPasswordHash(password, salt);
            return passwordHash;
        }
        public static string ComputeUserPasswordHash(string password, int salt)
        {
            return ComputeSha256(string.Format("{0}{1}", password, salt));
        }

        public static string ComputeSha256(string path)
        {
            using var hash = SHA256.Create();
            var messageBytes = Encoding.UTF8.GetBytes(path);
            var hashValue = hash.ComputeHash(messageBytes);

            return hashValue.Aggregate(string.Empty, (current, b) => current + string.Format("{0:x2}", b));
        }
    }
}
