using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var someDate =  DateTime.Now;
            var anotherDate = new DateTime(19, 3, 19);
            TimeSpan diff = anotherDate - someDate;
            var result = someDate.AddDays(5);
            Console.WriteLine(diff);
            Console.WriteLine(someDate.ToString("dddd"));
        }
    }
}
