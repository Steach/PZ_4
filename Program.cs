using System;
using System.IO.Pipes;

namespace PZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
