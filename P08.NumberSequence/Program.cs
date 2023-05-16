using System;

namespace P08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;    // за положителни и отрицатлни
            int minNumber = int.MaxValue;     //  maxNumber= 0; minNumber = 0;работи само за положителни
// така написа на 1ви цикъл въвежда веднага числото за макс и мин едновременно
            for (int i = 1; i <= n; i++)    // щом е число i = 1 !!
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }
                if (currentNum < minNumber)
                {
                    minNumber = currentNum;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
