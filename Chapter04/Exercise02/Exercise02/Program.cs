using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Exercise02
{
    class Program
    {
        //come back to this; do sieve of eratosthenes https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        static bool[] PrimeFactor(int userInput)
        {
            //Create my array that will be userInput long, defaults to false.
            bool[] eratosthenes = new bool[userInput];
            Debug.WriteLine($"The array is: {eratosthenes.Length}"); //output to the debug
            int j = 0;
            List<int> primes = new List<int>();

            for (int i = 0; i < Math.Sqrt(userInput); i++)
            {
                if (i < 1)
                {
                    Debug.WriteLine("Loop < 1");
                    continue;
                }
                else if (i == 2)
                {
                    Debug.WriteLine("===LOOP 2===");
                    Debug.WriteLine($"{i}^2");
                    j = Convert.ToInt32(Math.Pow(i, 2));
                    Debug.WriteLine($"{j}");
                    Debug.WriteLine($"{i}");
                    primes.Add((int)j);
                    eratosthenes[j] = true;
                    Debug.WriteLine("============");
                }
                else if (i == 3)
                {
                    Debug.WriteLine("===LOOP 3===");
                    Debug.WriteLine($"{i}^2 + {i}");
                    j = Convert.ToInt32(Math.Pow(i, 2)) + i;
                    Debug.WriteLine($"{j}");
                    Debug.WriteLine($"{i}");
                    primes.Add((int)j);
                    eratosthenes[j] = true;
                    Debug.WriteLine("============");
                }
                else if ((bool)eratosthenes.GetValue(i) == false && i >= 4)
                {
                    Debug.WriteLine($"===LOOP {i}===");
                    j = Convert.ToInt32(Math.Pow(i, 2)) + (i * i);
                    Debug.WriteLine($"{j}");
                    Debug.WriteLine($"{i}");
                    primes.Add((int)j);
                    eratosthenes[j] = true;
                    Debug.WriteLine("============");
                }
                else
                {
                    Debug.WriteLine("OUTSIDE OF LOOP!");
                    continue;
                }

                foreach(int q in primes)
                {
                    Debug.Write($"Primes: {q}, ");
                }
                Debug.WriteLine("");
            }
            return eratosthenes;
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
