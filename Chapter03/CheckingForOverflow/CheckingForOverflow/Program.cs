using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine(x);
                    x++;
                    Console.WriteLine(x);
                    x++;
                    Console.WriteLine(x);
                    x++;
                    Console.WriteLine(x);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The code overflowed, but I caught the exception.");
            }
            //int y = int.MaxValue + 1; //This will give an error because the compiler knows it will overflow
            unchecked
            {
                int y = int.MaxValue + 1;
                Console.WriteLine(y); //this will output -2147483648
                y--;
                Console.WriteLine(y); //this will output 2147483647
                y--;
                Console.WriteLine(y); //this will output 2147483646
            }
        }
    }
}
