using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex__Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            String convertNumber = number.ToString("X");

            Console.WriteLine(convertNumber);

            int remainder;
            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
