using System;

namespace Exercise02
{
    class Program
    {
        //come back to this; do sieve of eratosthenes https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        static int PrimeFactor(int userInput)
        {
            int prime;
            int divisionOfInput = userInput;
            int primeTest;
            do
            {
                divisionOfInput = (userInput / 2);
            }
            while ((divisionOfInput % 2) != 0);

            return prime;
        }

        static void CallPrimeFactor()
        {
             if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                PrimeFactor(userInput);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
