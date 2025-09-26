using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD
{
    public class GestionHachage
    {
        public class mdpHachage
        {

            public static string HashPassword(string password)
            {
                using (var sha1 = SHA1.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashedPasswordBytes = sha1.ComputeHash(passwordBytes);

                    // Convertir le résultat en hexadécimal
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashedPasswordBytes)
                    {
                        sb.Append(b.ToString("x2")); // "x2" format pour hexadécimal en minuscules
                    }
                    return sb.ToString();
                }
            }


        }
    }
}
