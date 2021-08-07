using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Demo.Enumerable.FullImplementation
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

            Console.WriteLine("- Before > while");
            using(var iterator = results.GetEnumerator())
            {
                while(iterator.MoveNext())
                {
                    var item = iterator.Current;
                    Console.WriteLine($"\t* Before > print > {item}");
                    Console.WriteLine($"\t\t$ {item}");
                    Console.WriteLine($"\t* After > print > {item}");
                }
            }
            Console.WriteLine("- After > while");

            stopwatch.Stop();
            Console.WriteLine();
            Console.Write($"Time spent: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private static IEnumerable<int> _getResults(int max) => new SampleEnumerable(max);
    }
}