using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a date in this format yyyy/mm/dd");
            DateTime d1 = new DateTime (Console.Read());

            Console.WriteLine("Input another date also in this format yyyy/mm/dd");
            DateTime d2 = new DateTime (Console.Read());

            TimeSpan span = d2 - d1;
            int hours = span.Hours;
            int minutes = span.Minutes;

            Console.WriteLine
                     ("There're {0} days {1} minutes and {2} seconds between these dates", span.TotalDays, hours, minutes);
            Console.ReadLine();

        }
    }
}
