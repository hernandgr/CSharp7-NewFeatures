using System;

namespace Tuples.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            OldTuples();
            NewValueTuples();

            Console.ReadKey();
        }

        private static void OldTuples()
        {
            var tuple = new Tuple<string, decimal>("T-Shirt", 100.0m);

            Console.WriteLine($"Product - Name: {tuple.Item1}, Price: {tuple.Item2}");
        }

        private static void NewValueTuples()
        {
            (string name, decimal price) tuple = ("T-Shirt", 100.0m);

            Console.WriteLine($"Product - Name: {tuple.name}, Price: {tuple.price}");
        }
    }
}