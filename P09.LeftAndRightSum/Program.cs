using System;

namespace P09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int LeftSum = 0;
            int RightSum = 0;
          
            for (int i = 1; i <= n ; i++)
            {
                LeftSum = LeftSum + int.Parse(Console.ReadLine());                
            }
            for (int i = 1; i <= n; i++)
            {
                RightSum = RightSum + int.Parse(Console.ReadLine());
            }

            if (LeftSum == RightSum)
            {
                Console.WriteLine($"Yes, sum = {LeftSum}");
            }
            else
            {
                int diff = Math.Abs(RightSum - LeftSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }

    }
}
