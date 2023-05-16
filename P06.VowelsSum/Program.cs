using System;
using System.Collections.Generic;

namespace P06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower(); // ToLower е за да направи вс букви малки
            int vowelSum = 0;                   // при сумиране почват от 0 при умножение от 1

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar == 'a')
                {
                    vowelSum += 1;
                }
                else if (currentChar == 'e')
                {
                    vowelSum += 2;
                }
                else if ( currentChar == 'i')
                {
                    vowelSum += 3;
                }
                else if ( currentChar == 'o')
                {
                    vowelSum += 4;
                }
                else if (currentChar == 'u')
                {
                    vowelSum += 5;
                }

            }
            Console.WriteLine( vowelSum );
        }

    }
}
