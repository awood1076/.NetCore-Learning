﻿using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");
            string input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch(FormatException)
            {
                WriteLine("The age you entered is nota valid number format.");
            }
            catch(OverflowException)
            {
                WriteLine("Your age is a valid number, but it is too large or too small.");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After Parsing");
        }
    }
}
