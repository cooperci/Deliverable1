using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            if (password.Length >= 7 && password.Length <= 12)
            {
                if (password.Contains("!") && password.Any(char.IsUpper) && password.Any(char.IsLower))
                {
                    Console.WriteLine("Password is valid and accepted");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

