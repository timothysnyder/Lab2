using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;

            DateTime endTime = DateTime.Now.AddSeconds();

            TimeSpan span = endTime.Subtract(startTime);
            Console.WriteLine("Time Difference (seconds): " + span.Seconds);
            Console.WriteLine("Time Difference (minutes): " + span.Minutes);
            Console.WriteLine("Time Difference (hours): " + span.Hours);
            Console.WriteLine("Time Difference (days): " + span.Days);
        }
    }
}
