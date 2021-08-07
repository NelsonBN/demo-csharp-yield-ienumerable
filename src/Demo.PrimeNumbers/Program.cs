using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.PrimeNumbers
{
    public class Program
    {
        public static void Main(string[] _)
        {
            Console.Write("Total of prime numbers: ");
            var input = Console.ReadLine();
            var max = Convert.ToInt32(input);

            var primeNumbers = Program._getPrimeNumbers().Take(max);

            int count = 1;
            foreach(var primeNumber in primeNumbers)
            {
                Console.WriteLine($"{count++}º Prime number: {primeNumber}");
            }
        }

        private static IEnumerable<int> _getPrimeNumbers()
        {
            int count = 1;
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
            for(int count = 2; count < max; count++)
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