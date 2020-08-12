using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VacationSystem
{
    class Hash
    {   //Set size of salt and hash
        private const int SaltSize = 16;
        private const int HashSize = 20;

        //Turns a passsword in to as hash
        public static string HashPassword(string password, int interations)
        {
            //Creates the salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            //Creates the hash
            var pb = new Rfc2898DeriveBytes(password, salt, interations);
            var hash = pb.GetBytes(HashSize);

            //Combines the salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            //Converts to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            //Formats the hash
            return string.Format("$HASH$V1{0}${1}", interations, base64Hash);
        }

        //If password is just sent to class then it creates a hashed password with 1000 iterations
        public static string HashPassword(string password)
        {
            return HashPassword(password, 1000);
        }

        //Verifiy hash is supported
        public static bool HashSupport(string hashedString)
        {
            return hashedString.Contains("$HASH$V1");
        }

        //Verification for password
        public static bool Verify(string password, string hashPassword)
        {
            if(!HashSupport(hashPassword))
            {
                throw new NotSupportedException("Incorrect Hash Entered");
            }

            //Extract iterations and Base64 string
            var splitHash = hashPassword.Replace("$HASH$V1", "").Split('$');
            var iterations = int.Parse(splitHash[0]);
            var base64Hash = splitHash[1];

            //Get hash bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            //Get the salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            //Create hash with salt
            var pb = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pb.GetBytes(HashSize);

            //Get result
            for(var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
