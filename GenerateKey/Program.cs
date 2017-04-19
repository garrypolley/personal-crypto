using System.Security.Cryptography;
using System;

namespace GenerateKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var hmac = new HMACSHA256();
            var key = Convert.ToBase64String(hmac.Key);
            Console.WriteLine($"Your key is: {key}");
        }
    }
}
