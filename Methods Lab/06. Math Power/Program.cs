using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, double power)
        {
            double result = 1;

            for (double i = 0; i < power; i++)

            {

                result *= number;

            }

            return result;

        }
    }
}
