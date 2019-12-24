using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            try
            {
                checked
                {   //What does this code do?
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }
                    //This code overflows at 255 because that is the max for a byte.
                    //It then loops endlessly since it will not terminate until i > max
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("Sorry! This statementoverflowed. Terminating.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception! Sorry, it looks like we have not caught this one before." +
                    $"\nSource: {ex.Source}" +
                    $"\nType: {ex.GetType()}" +
                    $"\nMessage: {ex.Message}" +
                    $"\nStack Trace: {ex.StackTrace}\n" +
                    $"\nInner Exception: {ex.InnerException}");
            }
        }
    }
}
