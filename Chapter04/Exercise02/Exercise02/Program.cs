using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Exercise02
{
    class Program
    {
        //come back to this; do sieve of eratosthenes https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        static List<int> PrimeFactor(int userInput)
        {
            //Create my array that will be userInput long, defaults to false.
            bool[] eratosthenes = new bool[userInput];
            Debug.WriteLine($"The array is: {eratosthenes.Length}"); //output to the debug
            int j = 0;
            List<int> primes = new List<int>();

            for (int i = 0; i < eratosthenes.Length; i++)
            {
                eratosthenes[i] = true;
            }

            Debug.WriteLine($"userInput = {userInput}");

            //Run this to run through all the non-primes. It runs through the below while y < userInput, then goes back up and starts over with x incremented by 1 until y = userInput, etc.
            for (int x = 2; x < userInput; x++)
            {
                Debug.WriteLine($"x = {x}");
                Debug.WriteLine($"y = x * 2");
                for (int y = x * 2; y < userInput; y = y + x)
                {
                    Debug.WriteLine($"y = {y} + {x}");
                    if (primes.Contains(y) == false)
                    {
                        primes.Add(y);
                        Debug.WriteLine($"{y} added to list");
                    }
                    Debug.WriteLine($"Now y will equal {y} + {x} or y + x");
                }
            }
            
            // scroll through the list and see what numbers are on there between 2 and user input; if it does exist on the list, it is NOT a prime.
            for (int i = 2; i < userInput; i++)
            {
                if (primes.Contains(i) == false)
                {
                    Console.Write($"{i}, ");
                }
            }
            return primes;
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
            CallPrimeFactor();
        }
    }
}
