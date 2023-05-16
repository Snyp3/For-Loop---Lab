using System;

namespace P05._CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); //Console.ReadLine().ToLower
                                              //ако искаме да конвертира вс в малки

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
