using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int end = int.Parse(Console.ReadLine());
            for (int i = 0; i < end; i++)
            {
                PrintLine(1,i);
            }
            for (int i = end; i >0; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }
    }
}
