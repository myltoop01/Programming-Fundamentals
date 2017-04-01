using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            while (a == 0)
            {
                var inputDate = Console.ReadLine();
                var date = DateTime.Parse(inputDate);
                Console.WriteLine(date.DayOfWeek);
            }
        }
    }
}
