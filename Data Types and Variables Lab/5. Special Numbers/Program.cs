using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= number; i++)
            {
                int sumOfDigit = 0;
                int digit = i;
                while (digit > 0)
                {
                    sumOfDigit += digit % 10;
                    digit = digit / 10;
                }
                bool special = (sumOfDigit == 5 || sumOfDigit == 7 || sumOfDigit == 11);
                Console.WriteLine("{0} -> {1}",i,special);
            }
        }
    }
}
