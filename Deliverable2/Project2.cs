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
            Console.WriteLine("Hello, can you give me a date, before when you were born, ");
            Console.WriteLine("that you think would have been fun to live in. ");
            Console.WriteLine("Please input your first date in this format yyyy/mm/dd");
            string d1 = Console.ReadLine();
            Convert.ToDateTime(d1);
            
            Console.ReadLine();



            Console.WriteLine("Now if you will please give me your actual birth date. ");
            Console.WriteLine("Can you also please input the date in this format yyyy/mm/dd");
            DateTime d2 = new DateTime(Console.Read());
            Convert.ToDateTime(d2);
            Console.ReadLine();


            TimeSpan span = d2 - d1;
            int hours = span.Hours;
            int minutes = span.Minutes;

            Console.WriteLine
                     ("There're {0} days {1} minutes and {2} seconds between these dates", span.TotalDays, hours, minutes);
            Console.ReadLine();



        }
    }
}
