using System;

namespace duration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check arguments
            int argsLength = args.Length;
            if(argsLength != 2)
            {
                Console.WriteLine("Usage: duration <Start Date> <End Date>");
                Console.WriteLine();
                Console.WriteLine("Arguments:");
                Console.Write("  <Start Date>\t");
                Console.Write("Format: yyyy-MM-dd ");
                Console.WriteLine("(ex. 2017-01-31)");
                Console.Write("  <End Date>\t");
                Console.Write("Format: yyyy-MM-dd ");
                Console.WriteLine("(ex. 2018-01-31)");
                return;
            }

            // Declare variables
            DateTime startDate;
            DateTime endDate;

            // Try to parse args[0] which is Start Date
            if (!DateTime.TryParse(args[0], out startDate))
            {
                Console.Write("Invalid date format: ");
                Console.WriteLine(args[0]);
                return;
            }

            // Try to parse args[1] which is End Date
            if (!DateTime.TryParse(args[1], out endDate))
            {
                Console.Write("Invalid date format: ");
                Console.WriteLine(args[1]);
                return;
            }

            // Calculate duration between the two dates
            int duration = (int)((endDate - startDate).TotalDays);
            if(duration < 0)
            {
                Console.Write("ERROR: ");
                Console.Write("<End Date> must be after <Start Date>");
                return;
            }

            // Display result to user
            Console.Write("Total days from ");
            Console.Write(args[0]);
            Console.Write(" to ");
            Console.Write(args[1]);
            Console.Write(" is ");
            Console.Write(duration);
            Console.Write(" day");
            Console.WriteLine(duration >= 1 ? "s" : "");
            return;
        }
    }
}
