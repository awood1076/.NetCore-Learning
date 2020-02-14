using System;
using System.Diagnostics;
using System.IO;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            //Text Writer is buffered, so this option calls Flush() on all listeners after writing
            Trace.AutoFlush = true;
            
            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

            var ts = new TraceSwitch("PacketSwitch", "This switch is set via command line.");

            if (args.Length > 0)
            {
                if (System.Enum.TryParse<TraceLevel>(args[0], ignoreCase: true, result: out TraceLevel level))
                {
                    ts.Level = level;
                }
            }

            Trace.WriteLineIf(ts.TraceError, "Trace Error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");
        }
    }
}
