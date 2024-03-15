using System;
using System.IO.Pipes;

namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Branch with all PZ_4 tasks

            /*
            int count = 50;
            int step = 2;
            int[] numbers = new int[count];
            for (int i = 2, j = 0; j < count; i += step, j++)
                numbers[j] = i;
        

            foreach (int num in numbers)
                Console.WriteLine(num);

            Console.WriteLine($"Length of the numbers: {numbers.Length}");
            */

            /*
            int minRange = 24;
            int maxRange = 50;
            int maxNum = 50;

            Random randomizer = new Random();

            int count = randomizer.Next(minRange, maxRange);
            int pairedCounter = 0;
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = randomizer.Next(maxNum);
                if (numbers[i] % 2 == 0)
                    pairedCounter++;
            }

            Console.WriteLine($"Length of the numbers: {numbers.Length}");
            Console.WriteLine($"Paired numbers: {pairedCounter}");
            Console.Write("It's: ");

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    Console.Write($"{num} ");
            }
            */

            /*
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
            */

            /*
            int firstAsciiSymbol = 97;
            int lastAsciiSymbol = 122;
            int countOfSymbols = 26;

            byte[] ascii = new byte[countOfSymbols];
            char[] symbols = new char[countOfSymbols];

            for (int i = firstAsciiSymbol, j = 0; i <= lastAsciiSymbol; i++, j++)
            {
                ascii[j] = (byte)i;
                symbols[j] = (char)ascii[j];
                Console.WriteLine($"Symbol: {symbols[j]} - ASCII: {ascii[j]}");
            }
            */
        }
    }
}
