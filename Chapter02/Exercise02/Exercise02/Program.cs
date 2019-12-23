using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            string[] dataType = 
            {
                "sbyte",
                "byte",
                "short",
                "ushort",
                "int",
                "uint",
                "long",
                "ulong",
                "float",
                "double",
                "decimal"

            };

            double[] memSize = 
            {
                sizeof(sbyte),
                sizeof(byte),
                sizeof(short),
                sizeof(ushort),
                sizeof(int),
                sizeof(uint),
                sizeof(long),
                sizeof(ulong),
                sizeof(float),
                sizeof(double),
                sizeof(decimal)
            };

            double[] minRange =
            {
                sbyte.MinValue,
                byte.MinValue,
                short.MinValue,
                ushort.MinValue,
                int.MinValue,
                uint.MinValue,
                long.MinValue,
                ulong.MinValue,
                float.MinValue,
                double.MinValue,
                (double)decimal.MinValue
            };

            double[] maxRange =
            {
                sbyte.MaxValue,
                byte.MaxValue,
                short.MaxValue,
                ushort.MaxValue,
                int.MaxValue,
                uint.MaxValue,
                long.MaxValue,
                ulong.MaxValue,
                float.MaxValue,
                double.MaxValue,
                (double)decimal.MaxValue
            };
            
            while (counter < 120)
            {
                Write("-");
                counter++;
            }
            counter = 0;

            Write("{0,-10} {1,11} {2,45} {3,45}\n", "Name", "Memory Size","Min","Max");
            while (counter < 120)
            {
                Write("-");
                counter++;
            }
            counter = 0;
            WriteLine();

            for (counter = 0; counter < dataType.Length; counter++)
            {
                WriteLine("{0,-10} {1,11} {2,45} {3,45}",dataType[counter], memSize[counter], 
                    minRange[counter], maxRange[counter]);
            }
            counter = 0;

            while (counter < 120)
            {
                Write("-");
                counter++;
            }
            counter = 0;
        }

    }
}
