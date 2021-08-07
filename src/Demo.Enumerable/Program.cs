using System;
using System.Linq;

namespace DemoYieldEnumerable
{
    public class Program
    {
        public static void Main(string[] _)
        {
            Console.WriteLine("Sample count up");

            var items = Enumerable
                .Range(1, 20);

            foreach(var item in items)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Sample countdown");

            items = Enumerable
                .Range(1, 20)
                .Reverse();

            foreach(var item in items)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Sample even number count");

            items = Enumerable
                .Range(1, 20)
                .Where(w => w % 2 == 0);

            foreach(var item in items)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Sample odd number count");

            items = Enumerable
                .Range(1, 20)
                .Where(w => w % 2 == 1);

            foreach(var item in items)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Sample days of week");

            var daysOfWeek = Enumerable
                .Range(0, 6)
                .Select(s => (DayOfWeek)s);

            foreach(var item in daysOfWeek)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Application end!!!");
        }
    }
}