using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;
            int pwdtries = 0;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                pwdtries++;
            } while (password != "secret" & pwdtries < 10);
            
            if (password == "secret")
            {
                WriteLine("Correct!");
            };
            if (pwdtries >= 10 & password != "secret")
            {
                WriteLine("Sorry, you only get 10 tries.");
            };

            string[] names =
            {
                "Adam",
                "Barry",
                "Charlie"
            };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
