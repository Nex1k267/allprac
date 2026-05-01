using System;

namespace Pract8_Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            string password = "";
            for (int i = 0; i < 8; i++)
                password += chars[rnd.Next(chars.Length)];
            Console.WriteLine(password);
        }
    }
}