using System;

namespace Discards.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Discards()
        {
            // Out value without discard
            int price;
            if (int.TryParse("10", out price))
            {
                // ...
            }

            // Out value with discard
            if (int.TryParse("10", out int _))
            {
                // ...
            }

            // Discard value in tuples
            var (_, _, role) = GetEmployeeData();
            if (role == "Contractor")
            {
                // ...
            }
        }

        public static (string name, int age, string role) GetEmployeeData()
        {
            return ("Juan", 10, "Contractor");
        }
    }
}