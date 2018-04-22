using System;
using System.Diagnostics;

namespace big_o_notation_data_structure
{
    class Program
    {
        private static int SIZE_LOG_LINES = 100000;
        private static int SIZE_UNIQUE_IPS = 90001;
        private static LogReader logReader = new LogReader(SIZE_LOG_LINES, SIZE_UNIQUE_IPS, CollectionType.ArrayList);

        static void Main(string[] args)
        {
            Console.WriteLine("Reading all log entries...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sizeLogLines = logReader.readAllLogs();
            Console.WriteLine("Number of lines: " + sizeLogLines);
            Console.WriteLine(string.Format("Time elapsed: {0} milliseconds", stopwatch.Elapsed) + "\n");

            Console.WriteLine("\nProcessing unique IPs...");

            stopwatch.Reset();
            stopwatch.Start();
            int sizeUniqueIps = logReader.getSizeUniqueIps();
            Console.WriteLine(String.Format("Number of unique IPs: {0}", sizeUniqueIps));
            Console.WriteLine(string.Format("Time elapsed: {0} seconds", stopwatch.Elapsed.TotalSeconds) + "\n");

            Console.ReadLine();
        }
    }
}
