using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool userInput;
                byte numberPressed;
                do
                {
                    Console.WriteLine("Please enter a whole number between 0 and 255.");
                    userInput = byte.TryParse(Console.ReadLine(), out numberPressed);
                    if (userInput == false)
                    {
                        Console.WriteLine("Your input was not a whole number between 0 and 255.");
                    }
                }    while (userInput != true);
                    if(userInput == true)
                {
                    Console.WriteLine("Thank you!");
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("The number you entered was either too large or too small.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Please input a whole number between 0 and 255.");
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
