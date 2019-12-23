using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        //Output numbers and their ranges
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store" +
                $" numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine();

            Console.WriteLine($"double uses {sizeof(double)} bytes and can" +
                $" store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
            Console.WriteLine();

            Console.WriteLine($"Decimal uses {sizeof(decimal)} bytes and can store numbers" +
                $" in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
            Console.WriteLine();

        //Explore the Double type - don't use it for precise math.
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
            Console.WriteLine();



        }
    }
}
