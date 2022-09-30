using System;

namespace Uppgift3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gamal är du?");
            int svar = int.Parse(Console.ReadLine());

            if (svar < 16)
                Console.WriteLine("Du får inte delta i tavling");
            else if (svar > 19)
                Console.WriteLine("Du får inte delta i tavling");
            else if (svar >= 16 && svar <= 19)
                Console.WriteLine("Du får delta i tavling");
        }
    }
}