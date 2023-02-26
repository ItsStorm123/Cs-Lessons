
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSussy
{
    public static class Day1
    {

        public static void Start()
        {

            Trace.TraceInformation("Test message.");
            Trace.TraceInformation(Trace.Listeners.Count.ToString());

            Trace.TraceInformation(Trace.Listeners[0].ToString());

            // You must close or flush the trace to empty the output buffer.
            Trace.Flush();



            Console.ReadLine();
        }

    }
}
