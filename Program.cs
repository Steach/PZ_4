using System;
using System.IO.Pipes;

namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 50;
            int step = 2;
            int[] numbers = new int[count];
            for (int i = 2, j = 0; j < count; i += step, j++)
                numbers[j] = i;
        

            foreach (int num in numbers)
                Console.WriteLine(num);

            Console.WriteLine($"Length of the numbers: {numbers.Length}"); 
        }
    }
}
