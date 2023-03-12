using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppSussy
{
    public class Day2
    {

        public void Test()
        {

            long a = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                a = (long)(i * 1.1M);
            }
            Console.ReadKey();
        }

        public void Test2()
        {
            if (CreatePerformanceCounters())
            {
                Console.WriteLine("Created performance counters");
                Console.WriteLine("Please restart application");
                Console.ReadKey();

                return;
            }
            var totalOperationsCounter = new PerformanceCounter("MyCategory", "# operations executed", "", false);
            var operationsPerSecondCounter = new PerformanceCounter("MyCategory", "# operations / sec", "", false);
            totalOperationsCounter.Increment();
            operationsPerSecondCounter.Increment();
        }

        private static bool CreatePerformanceCounters()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                CounterCreationDataCollection counters =
                new CounterCreationDataCollection
                {
                    new CounterCreationData
                    (
                        "# operations executed",
                        "Total number of operations executed",
                        PerformanceCounterType.NumberOfItems32
                    ),
                        new CounterCreationData(
                            "# operations / sec",
                            "Number of operations executed per second",
                            PerformanceCounterType.RateOfCountsPerSecond32
                        )
                };
                PerformanceCounterCategory.Create
                (
                    "MyCategory",
                    "Sample category for Codeproject", counters
                );

                return true;
            }

            return false;
        }
    }
}
