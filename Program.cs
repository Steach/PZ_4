using System;
using System.IO.Pipes;

namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the text: ");
            string text = Console.ReadLine();
            int textCounter = 0;
            int symbolCounter = 0;
            Console.WriteLine($"Your text: {text}");

            foreach (char str in text)
                textCounter++;

            Console.WriteLine($"Text \"{text}\" include: {textCounter} symbols.");
            Console.WriteLine($"Enter the symbol you want to find: ");

            char findSymbol;
            while (!char.TryParse(Console.ReadLine(), out findSymbol))
            {
                Console.WriteLine("Invalid format. Please enter one symbol: ");
            }
            findSymbol = char.ToLower(findSymbol);

            foreach (char str in text) 
            {
                if (char.ToLower(str) == findSymbol)
                    symbolCounter++;
            }

            Console.WriteLine($"Text \"{text}\" include: {symbolCounter} \"{findSymbol}\" symbols");  
        }
    }
}
