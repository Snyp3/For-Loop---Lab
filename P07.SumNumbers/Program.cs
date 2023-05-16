using System;

namespace P07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0; // винаги почва от 0 щом е число и винаги преди цикъл а не в него

            for (int i = 0; i < n; i++) //според зависи дали i = 1 или i = 0
                                        //               i <= n    i < n  
 //•	От следващите n реда се въвежда по едно цяло число. <--- значи for цикъл(ако се падне на изпит
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

            }

            Console.WriteLine(sum);
        }
    }
}
