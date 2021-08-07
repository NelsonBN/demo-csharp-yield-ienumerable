using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Demo.WithoutYield
{
    public class Program
    {
        public static void Main(string[] _)
        {
            Console.Write("Max value: ");
            var input = Console.ReadLine();
            var max = Convert.ToInt32(input);


            var stopwatch = Stopwatch.StartNew();


            Console.WriteLine("# Before > _getResults");
            var results = Program._getResults(max);
            Console.WriteLine("# After > _getResults");


            Console.WriteLine("- Before > foreach");
            foreach(var item in results)
            {
                Console.WriteLine($"\t* Before > print > {item}");
                Console.WriteLine($"\t\t$ {item}");
                Console.WriteLine($"\t* After > print > {item}");
            }
            Console.WriteLine("- After > foreach");

            stopwatch.Stop();
            Console.WriteLine();
            Console.Write($"Time spent: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private static IEnumerable<int> _getResults(int max)
        {
            var result = new int[max];

            Console.WriteLine("\t> Before > loop");
            for(var count = 0; count < max; count++)
            {
                var value = count * 2;
                Console.WriteLine($"\t\t» Before > create > {value}");
                result[count] = value;
                Console.WriteLine($"\t\t» After > create > {value}");
            }
            Console.WriteLine("\t> After > loop");

            return result;
        }
    }
}