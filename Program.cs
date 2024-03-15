using System;
using System.IO.Pipes;

namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
