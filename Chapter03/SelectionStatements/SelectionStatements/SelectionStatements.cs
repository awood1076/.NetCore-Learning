using System;
using System.IO;
using static System.Console;

namespace Chapter_03
{
    class SelectionStatements
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

            object o = 3;
            int j = 4;

            if(o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch(number)
            {
                case 1:
                    WriteLine("One");
                    break; //ends statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or Four");
                    goto case 1;
                case 5:
                    //go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            } //end of switch statement
            string path = @"C:\Users\aaron\OneDrive\code\.NetCore-Learning\Chapter-03";
            Stream s = File.Open(
                Path.Combine(path, "file.txt"),
                FileMode.OpenOrCreate);

            switch(s)
            {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address.");
                    break;
                default: //always evaluated last no matter the position
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }

        }
    }
}
