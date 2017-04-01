using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static void PrintSign(double number)
        {

            if (number > 0)

                Console.WriteLine("The number {0} is positive", number);

            else if (number < 0)

                Console.WriteLine("The number {0} is negative.", number);

            else

                Console.WriteLine("The number {0} is zero.", number);

        }
    }
}
