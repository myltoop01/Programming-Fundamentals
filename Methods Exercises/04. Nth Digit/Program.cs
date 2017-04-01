using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number,index));
        }
        static int FindNthDigit(long number, int index)
        {
            long lastNumber = number;
            for (int i = 0; i < index; i++)
            {
                lastNumber = number % 10;
                number = number / 10;
            }
            return (int)lastNumber;





        }


    }
}
