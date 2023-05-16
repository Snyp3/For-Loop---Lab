using System;

namespace P04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 
            for (int pow = 0; pow <= n ; pow+= 2)   // int = 0 и pow += 2 все едно са четни
            {
                Console.WriteLine(Math.Pow(2, pow)); // мат пол  степенуване

            }
        }
    }
}
