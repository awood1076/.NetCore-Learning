using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; //an int can be stored in a double
            WriteLine(b);

            //Losing precision just chops it off
            double c = 9.8;
            //int d = c; //compiler gives an error
            int d = (int)c; //d will lose the .8 part
            WriteLine(d);

            //Casting a larger value into a smaller data type ends up with -1
            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");

            //Convert uses Banker's Rounding
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            //proof of banker's rounding in which the even or odd part of the non-decimal matters too
            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}");

            //String conversions
            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            //allocate an array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate the array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Object as bytes: ");
            for(int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X}");
            }
            WriteLine();

            //Convert to Base64 string. Notice the [index]:X, the :X means format as hex instead of base 10
            string encoded = Convert.ToBase64String(binaryObject);
            byte[] decoded = new byte[128];
            decoded = Convert.FromBase64String(encoded);

            WriteLine($"Binary Object as Base64: {encoded}");
            WriteLine("Back to the byte array: ");
            for(int index = 0; index < decoded.Length; index++)
            {
                Write($"{decoded[index]:X}");
            }

            //Converting dates and parsing
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            //int count = int.Parse("abc"); //this will throw a System.FormatException
            Write("How many eggs are there?");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }

        }
    }
}
