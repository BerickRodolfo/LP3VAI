using System;

namespace LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "MIAU", "AUAU", "MUUU" };
            int count = 0;

            foreach (string element in palavras)
            {
                count++;
                Console.WriteLine($"Elemento: {count}: {element}");
            }
            Console.WriteLine($"Numbero de elementos: {count}");
        }
    }