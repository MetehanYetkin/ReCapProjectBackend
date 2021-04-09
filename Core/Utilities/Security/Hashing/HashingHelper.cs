using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //out kullandığımız için bunları da döndürmüş olacağız.(return gibi)
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//byteye çevirmek için bu şekilde yaparız.

            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//saltı kullanıyoruz burada.
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//aynı şekilde birdaha oluşturduk.
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }

                }
                return true;
            }

        }
    }
}
