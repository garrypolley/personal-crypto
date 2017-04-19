using System.Security.Cryptography;
using System;

namespace GenerateKey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stolen from: http://stackoverflow.com/a/17576032/1686511
            var hmac = new HMACSHA256();
            var key = Convert.ToBase64String(hmac.Key);
            Console.WriteLine($"Your key is: {key}");
        }
    }
}
