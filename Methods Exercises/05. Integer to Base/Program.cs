using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            var convertet = IntegerToBase(number, toBase);
            Console.WriteLine(convertet);
        }
        static string IntegerToBase(long number, int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }

    }
}
