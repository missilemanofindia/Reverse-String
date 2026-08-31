using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReportthroughArgs
{
    class ArgsResport
    {
        static void Main(string[] args)
        {
            // 1. Safety Check: Did the user actually provide an argument?
            if (args.Length == 0)
            {
                Console.WriteLine("Error: No mode specified.");
                Console.WriteLine("Usage: ReportTool.exe [daily | monthly]");
                return; // Stop the program early
            }

            // 2. Grab the first argument and make it lowercase so "Daily" or "DAILY" both work
            string mode = args[0].ToLower();

            // 3. Switch behavior based on the argument provided
            switch (mode)
            {
                case "daily":
                    RunDailyReport();
                    break;

                case "monthly":
                    RunMonthlyReport();
                    break;

                default:
                    Console.WriteLine($"Error: '{mode}' is not a recognized mode.");
                    Console.WriteLine("Please use 'daily' or 'monthly'.");
                    break;
            }
            Console.ReadLine();
        }

        static void RunDailyReport()
        {
            Console.WriteLine("=== Running Fast Daily Report ===");
            Console.WriteLine("Fetching today's sales data...");
            Console.WriteLine("Sending quick Slack notification to the team.");
            Console.WriteLine("Done! Took 2 seconds.");
        }

        static void RunMonthlyReport()
        {
            Console.WriteLine("=== Running Heavy Monthly Report ===");
            Console.WriteLine("Aggregating millions of database rows for the entire month...");
            Console.WriteLine("Calculating company tax estimates and profit margins...");
            Console.WriteLine("Generating PDF and emailing it to the executives.");
            Console.WriteLine("Done! Took 45 seconds.");
        }
    }
    
}
