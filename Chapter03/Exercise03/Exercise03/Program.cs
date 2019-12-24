using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string counterString;
            decimal counter;
            decimal counterFizz;
            decimal counterBuzz;
            int fizz;
            int buzz;
            for (counter = 1; counter < 100; counter++)
            {
                counterFizz = (counter / 3);
                counterBuzz = (counter / 5);
                try
                {
                    //Create a string to try and parse for the TryParse. If counterFizz can be parsed to Int, it is a whole number divisible by 3. Output the number to fizz or buzz if needed.
                        //if counterBuzz can be parsed to Int, it is a whole number divisible by 5.
                        ///TryParse always returns true or false if it succeeds or not.
                    counterString = counter.ToString();
                    bool fizzSuccess = Int32.TryParse(counterFizz.ToString(), out fizz);
                    bool buzzSuccess = Int32.TryParse(counterBuzz.ToString(), out buzz);
                    bool fizzBuzzSuccess = (fizzSuccess & buzzSuccess);
                    //Print all the info nice and neat for building
//                  Console.WriteLine("Fizz {0} | Buzz {1} | FizzBuzz {2} | {3} | {4} | {5}", fizzSuccess, buzzSuccess, fizzBuzzSuccess, counter, counterFizz, counterBuzz);
                    
                    //Print Fizz if it is a number divisible by 3, print Buzz if it is divisible by 5, FizzBuzz for both, and just the number if none.
                    if (fizzSuccess == true && buzzSuccess == false)
                    {
                        Console.Write("Fizz, ");
                    }
                    else if (fizzSuccess == false && buzzSuccess == true)
                    {
                        Console.Write("Buzz, ");
                    }
                    else if (fizzSuccess == true && buzzSuccess == true)
                    {
                        Console.Write("FIZZBUZZ, ");
                    }
                    else
                    {
                        Console.Write($"{counter}, ");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception!" +
                                        $"\nSource: {ex.Source}" +
                                        $"\nType: {ex.GetType()}" +
                                        $"\nMessage: {ex.Message}" +
                                        $"\nStack Trace: {ex.StackTrace}\n" +
                                        $"\nInner Exception: {ex.InnerException}");
                }
            }
        }
    }
}
