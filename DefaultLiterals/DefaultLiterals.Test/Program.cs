using System;

namespace DefaultLiterals.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            OldWay();
            NewWay();

            Console.ReadKey();
        }

        private static void OldWay()
        {
            int i = default(int);
            string str = default(string);
            Product p = default(Product);
        }

        private static void NewWay()
        {
            int i = default;
            string str = default;
            Product p = default;

            if (i == default)
            {
                Console.WriteLine($"i is default {i}");
            }

            i = 2;

            if (i != default)
            {
                Console.WriteLine($"i is not default now. The new value is {i}");
            }
        }

    }
}
