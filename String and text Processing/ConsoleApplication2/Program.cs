using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           var totalOperation = 200000;
            var stopwatch = Stopwatch.StartNew();
            var a = "a";
            for (int i = 0; i < totalOperation; i++)
            {
                a += "a";
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch = Stopwatch.StartNew();
            var result = new StringBuilder();
            for (int i = 0; i < totalOperation; i++)
            {
                result.Append("a");

            }
            var resultAsString = result.ToString();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch = Stopwatch.StartNew();
            var b = 1;
            for (int i = 0; i < totalOperation; i++)
            {
                b += 5;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            
            Console.WriteLine(result.Capacity);
        }
    }
}
