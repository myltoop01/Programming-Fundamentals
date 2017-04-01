using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int min = 320000000;
                 

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i]< min)
                {
                    min = input[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
