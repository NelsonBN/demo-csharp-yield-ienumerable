using System;
using System.Collections.Generic;

namespace Demo.PrimeNumbers.AskMore
{
    public class Program
    {
        public static void Main(string[] _)
        {
            var primeNumbers = Program._getPrimeNumbers();

            ConsoleKey key = ConsoleKey.N;
            int total = 1;

            using(var iterator = primeNumbers.GetEnumerator())
            {
                do
                {
                    for(int count = 0; count < 10; count++)
                    {
                        if(iterator.MoveNext())
                        {
                            Console.WriteLine($"{total++}º Prime number: {iterator.Current}");
                        }
                        else
                        {
                            break;
                        }
                    }

                    Console.WriteLine();

                    Console.Write("Do you want to show more 10 results ['Y' to show]: ");
                    key = Console.ReadKey().Key;

                    Console.WriteLine();
                    Console.WriteLine();
                }
                while(key == ConsoleKey.Y);
            }
        }

        private static IEnumerable<int> _getPrimeNumbers()
        {
            var count = 1;
            while(true)
            {
                if(Program._isPrimeNumber(count))
                {
                    yield return count;
                }

                count++;
            }
        }

        private static bool _isPrimeNumber(int value)
        {
            var max = value / 2;
            for(var count = 2; count < max; count++)
            {
                if(value % count == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}