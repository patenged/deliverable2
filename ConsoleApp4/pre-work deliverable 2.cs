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
            //inputs
            Console.WriteLine("To find the difference in two dates " +
                "please enter the first date in MM/DD/YYYY format.");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the secound date in MM/DD/YYYY format.");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            //math
            var year1 = date1.Year;
            var year2 = date2.Year;
            var months1 = year1 * 12 + date1.Month;
            var months2 = year2 * 12 + date2.Month;
            TimeSpan difference = (date2 - date1);

            //outputs
            Console.WriteLine();
            Console.WriteLine("Difference in years");
            Console.WriteLine(year2 - year1);
            Console.WriteLine();
            Console.WriteLine("Difference in months");
            Console.WriteLine(months2 - months1);
            Console.WriteLine();
            Console.WriteLine("Difference in days");
            Console.WriteLine(difference.TotalDays);
            Console.WriteLine();
            Console.WriteLine("Difference in hours");
            Console.WriteLine(difference.TotalHours);
            Console.WriteLine();
            Console.WriteLine("Difference in minutes");
            Console.WriteLine(difference.TotalMinutes);
            Console.WriteLine();
        }
    }
}
