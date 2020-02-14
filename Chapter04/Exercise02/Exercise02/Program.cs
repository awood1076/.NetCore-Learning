using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Exercise02
{
    class Program
    {
        //sieve of eratosthenes https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        static List<int> PrimeFactors(int userInput)
        {
            List<int> notPrimes = new List<int>();
            List<int> primes = new List<int>();
            Debug.WriteLine($"userInput = {userInput}");

            //Run this to run through all the non-primes. It runs through the below while y < userInput, then goes back up and starts over with x incremented by 1 until y = userInput, etc.
            for (int x = 2; x < userInput; x++)
            {
                Debug.WriteLine($"x = {x} < userInput {userInput}");
                for (int y = x * 2; y < userInput; y += x)
                {
                    if (notPrimes.Contains(y) == false)
                    {
                        notPrimes.Add(y);
                        Debug.WriteLine($"{y} added to list");
                    }
                    Debug.WriteLine($"y = {y} + {x}");
                }
            }
            
            // scroll through the list and see what numbers are on there between 2 and user input; if it does exist on the list, it is NOT a prime.
            for (int i = 2; i < userInput; i++)
            {
                if (notPrimes.Contains(i) == false)
                {
                    Debug.WriteLine($"{i} added to primes...\n");
                    primes.Add(i);
                }
            }

            //scroll through the list and multiply i (starting at 2) by the prime number in the list; if it 
            //TODO: Need to make sure i is also prime.
            List<int> primeFactorsUserInput = new List<int>();
            for (int i = 2; i < primes.Count; i++)
            {
                if (i * primes[i] == userInput)
                {
                    primeFactorsUserInput.Add(primes[i]);
                    Debug.WriteLine($"Added {i}\n");
                }
                i++;
                Debug.WriteLine($"i++ i is now {i}...\n");
            }
            Debug.WriteLine($"primeFactorsUserInput = {primeFactorsUserInput}");
            return primeFactorsUserInput;
        }

        static void MultiplyPrimeFactor()
        {
             if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                List<int> primes = PrimeFactors(userInput);
                Console.WriteLine($"Prime factors of {userInput} are: ");
                for(int i = 0; i < primes.Count; i++)
                {
                    Console.Write($"{primes[i]}, ");
                }
            }
        }

        static void Main(string[] args)
        {
            MultiplyPrimeFactor();
        }
    }
}
